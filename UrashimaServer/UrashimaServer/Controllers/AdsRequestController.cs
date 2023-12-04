﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using UrashimaServer.Database;
using UrashimaServer.Database.Dtos;
using UrashimaServer.Database.Models;

namespace UrashimaServer.Controllers
{
    [Route("api/ads-request")]
    [ApiController]
    public class AdsRequestController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public AdsRequestController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/ads-request/all
        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<AdsCreationRequest>>> GetAllCreateRequest()
        {
            var res = await _context.AdsCreationRequests
                .Include(x => x.AdsBoards)
                .ToListAsync();

            return res;
        }

        //POST: api/ads-request
        [HttpPost]
        public async Task<IActionResult> PostCreateRequest(AdsCreateRequestDto createRequest)
        {
            var request = _mapper.Map<AdsCreationRequest>(createRequest);
            var boardList = request.AdsBoards;

            if (boardList is not null)
            {
                request.AdsBoards = null;
            }

            if (_context.AdsCreationRequests == null)
            {
                return Problem("Entity set 'DataContext.AdsCreationRequest' is null.");
            }

            var tempPoint = await _context.AdsPoints.FindAsync(request.AdsPointId);
            request.RequestStatus = "Unconfirmed";
            _context.AdsCreationRequests.Add(request);

            try
            {
                await _context.SaveChangesAsync();

                if (tempPoint != null && tempPoint.Id != 0 && boardList != null)
                {
                    if (_context.AdsPoints.Any(e => e.Id == tempPoint.Id))
                    {
                        foreach (var board in boardList)
                        {
                            board.AdsPointId = tempPoint.Id;
                            board.AdsCreateRequestId = request.Id;
                            _context.AdsBoards.Add(board);
                        }
                    };
                }

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CreateRequestExists(request.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Ok(new {
                message = "Ok"
            });
        }

        // DELETE: api/ads-request
        [HttpDelete("")]
        public async Task<IActionResult> DeleteAdsBoard([FromQuery, Required] int id)
        {
            var role = "Ward";

            if (_context.AdsCreationRequests == null)
            {
                return NotFound();
            }
            var adsCreateRequest = await _context.AdsCreationRequests.FindAsync(id);
            if (adsCreateRequest == null)
            {
                return NotFound();
            }

            if (adsCreateRequest.RequestStatus == "Unconfirmed" && role == "Ward")
            {
                _context.AdsCreationRequests.Remove(adsCreateRequest);
                await _context.SaveChangesAsync();
            }

            return NoContent();
        }

        private bool CreateRequestExists(int id)
        {
            return (_context.AdsCreationRequests?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
﻿using AutoMapper;
using UrashimaServer.Database.Dtos;
using UrashimaServer.Database.Models;
using UrashimaServer.Models;

namespace UrashimaServer
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Map order
            // Ex: CreateMap<OrderItemDto, Order>().ReverseMap();
            CreateMap<AdsBoard, GetAdsBoardDto>().ReverseMap();
            CreateMap<AdsPoint, GetAdsPointDto>().ReverseMap();
            CreateMap<AdsPoint, PostAdsPointDto>().ReverseMap();

            // Map Ads_Point
            CreateMap<AdsPoint, UserAdsPointBasicDto>().ReverseMap();
            CreateMap<AdsPointImage, PointImageDto>().ReverseMap();
            CreateMap<AdsBoard, GetPointAdsBoardDto>().ReverseMap();
            CreateMap<AdsPoint, UserAdsPointDetailDto>().ReverseMap();

            // Map Ads_Board
            CreateMap<AdsBoard, AdsBoardBasicDto>().ReverseMap();

            // Map Report
            CreateMap<Report, ReportAdsBoardDto>().ReverseMap();
            CreateMap<ReportImage, ReportImageDto>().ReverseMap();
            CreateMap<Report, GetReportDto>().ReverseMap();
            CreateMap<Report, PostReportDto>().ReverseMap();
            CreateMap<Report, PostReportLocationDto>().ReverseMap();

            // Map Location
            CreateMap<GeoCodeResultDto, AddressResultDto>().ReverseMap();
            CreateMap<GeoCodeResultDto, GeoCodeResult>().ReverseMap();

            // Map create request
            CreateMap<AdsCreationRequest, AdsCreateBoardRequestDto>().ReverseMap();
            CreateMap<AdsCreationRequest, AdsCreatePointRequestDto>().ReverseMap();
            CreateMap<AdsBoard, AdsCreateRequestBoardDto>().ReverseMap();
            CreateMap<AdsPoint, AdsCreateRequestPointDto>().ReverseMap();
            CreateMap<AdsCreationRequest, GetAdsCreateRequestDto>().ReverseMap();

            // Map modify request
            CreateMap<PointModify, PointModifyDto>().ReverseMap();
            CreateMap<BoardModify, BoardModifyDto>().ReverseMap();
            CreateMap<PointModifyImage, PointModifyImageDto>().ReverseMap();

            // Map Account
            CreateMap<Account, AccountBasicInfoDto>().ReverseMap();

            CreateMap<AdsPointImage, PointModifyImage>().ReverseMap();
            CreateMap<AdsPoint, PointModify>().ReverseMap();
            CreateMap<AdsBoard, BoardModify>().ReverseMap();
        }
    }
}
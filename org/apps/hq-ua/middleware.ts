import { NextResponse } from 'next/server';
import type { NextRequest } from 'next/server';
import { HQ_PAGES } from '@constants/hqPages';
import { RequestCookie } from 'next/dist/compiled/@edge-runtime/cookies';
import { OFFICER_PAGES } from '@constants/officerPages';
import { generateSecureHash } from '@business-layer/business-logic/helper';

const isTokenValid = (token: RequestCookie | undefined) =>
  token && typeof token.value === 'string' && token.value.length > 0;

const getHostname = () =>
  process.env.NODE_ENV === 'development'
    ? 'localhost'
    : 'www.officer.urashima-ads.site';

export function middleware(request: NextRequest) {
  const cookie = request.cookies;
  const token = cookie.get(generateSecureHash('token' + getHostname()));
  const pathName = request.nextUrl.clone().pathname;
  const response = NextResponse;

  if (
    pathName === OFFICER_PAGES.AUTH ||
    pathName.startsWith(OFFICER_PAGES.SOCIAL_AUTH) ||
    pathName.startsWith(OFFICER_PAGES.RESET_PASSWORD) ||
    pathName.startsWith(OFFICER_PAGES.RESET_PASSWORD_NEW) ||
    pathName.startsWith(OFFICER_PAGES.RESET_PASSWORD_OTP)
  ) {
    if (isTokenValid(token)) {
      return response.redirect(new URL(HQ_PAGES.DASHBOARD, request.url));
    }
    return response.next();
  } else if (pathName === HQ_PAGES.ME) {
    if (!isTokenValid(token)) {
      return response.redirect(new URL(HQ_PAGES.AUTH, request.url));
    }
    return response.redirect(
      new URL(HQ_PAGES.PERSONAL_INFORMATION, request.url)
    );
  } else if (
    pathName.startsWith(HQ_PAGES.DASHBOARD) ||
    pathName.startsWith(HQ_PAGES.REGIONS) ||
    pathName.startsWith(HQ_PAGES.AD_SETTING) ||
    pathName.startsWith(HQ_PAGES.AD_LOCATIONS) ||
    pathName.startsWith(HQ_PAGES.AD_LOCATIONS_DETAIL) ||
    pathName.startsWith(HQ_PAGES.AD_LOCATIONS_MODIFICATION) ||
    pathName.startsWith(HQ_PAGES.AD_BOARDS) ||
    pathName.startsWith(HQ_PAGES.AD_REQUESTS) ||
    pathName.startsWith(HQ_PAGES.AD_MODIFICATION_REQUESTS) ||
    pathName.startsWith(HQ_PAGES.AD_APPROVE_REQUESTS) ||
    pathName.startsWith(HQ_PAGES.REPORTS) ||
    pathName.startsWith(HQ_PAGES.ACCOUNT_MANAGEMENT)
  ) {
    if (isTokenValid(token)) {
      return response.next();
    }
    return response.redirect(new URL(HQ_PAGES.AUTH, request.url));
  }
  return response.next();
}

export const config = {
  matcher: [
    /*
     * Match all request paths except for the ones starting with:
     * - api (API routes)
     * - _next/static (static files)
     * - _next/image (image optimization files)
     * - favicon.ico (favicon file)
     */
    '/((?!api|_next/static|_next/image|favicon.ico).*)',
  ],
};

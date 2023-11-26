// PROXY_URL
const proxyUrl = 'https://ura-ads.phucdat4102.workers.dev/cors-proxy/';
// 'https://cors-anywhere.herokuapp.com/';

// AUTH
export const loginUrl = '/v1/auth/login';
export const refreshTokenUrl = '/v1/auth/refresh-token';
export const updateAccountUrl = '/v1/auth/login-social';

// GOOGLE
export const googleGetUserInfoUrl =
  'https://people.googleapis.com/v1/people/me?personFields=names,emailAddresses';
export const googleValidateTokenUrl =
  'https://www.googleapis.com/oauth2/v3/tokeninfo';
// FACEBOOK
export const facebookGetFBAccessTokenUrl =
  'https://graph.facebook.com/v17.0/oauth/access_token';
export const facebookGetFBUserInfoUrl =
  'https://graph.facebook.com/me?fields=first_name,last_name,email';
// GITHUB
export const githubGetAccessTokenUrl =
  proxyUrl + 'https://github.com/login/oauth/access_token';
export const githubValidateTokenUrl = 'https://api.github.com/authorizations/';
export const githubGetUserInfoUrl = 'https://api.github.com/user';

export const exchangeratesapi = 'http://api.exchangeratesapi.io/v1';
export const exchangeratesGetLatestPath = '/latest';

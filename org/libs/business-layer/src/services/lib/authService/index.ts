import {
  loginUrl,
  officerChangePasswordUrl,
  officerForgotPasswordUrl,
  officerResetPasswordUrl,
  officerVerifyPasswordOtpUrl,
  refreshTokenUrl,
} from '../../config/apis';
import { Services } from '../../service';
import {
  authenticationResponseSchema,
  messageResponseSchema,
  refreshTokenResponseSchema,
} from './schema';
import {
  loginParamsType,
  tokenType,
  authenticationResponseType,
  refreshTokenResponseType,
  changePasswordParamsType,
  messageResponseType,
  forgotPasswordParamsType,
  verifyPasswordOtpParamsType,
  resetPasswordParamsType,
} from './type';

export * from './type';
export class AuthService extends Services {
  login = async (
    data: loginParamsType
  ): Promise<authenticationResponseType> => {
    this.abortController = new AbortController();
    try {
      const response = await this.fetchApi<
        typeof authenticationResponseSchema,
        authenticationResponseType
      >({
        method: 'POST',
        url: loginUrl,
        schema: authenticationResponseSchema,
        data,
        signal: this.abortController.signal,
        transformResponse: (res) => res,
      });
      return response;
    } catch (error) {
      throw this.handleError(error);
    }
  };
  refreshToken = async (
    refreshToken: tokenType
  ): Promise<refreshTokenResponseType> => {
    this.abortController = new AbortController();
    try {
      const response = await this.fetchApi<
        typeof refreshTokenResponseSchema,
        refreshTokenResponseType
      >({
        method: 'POST',
        url: refreshTokenUrl,
        schema: refreshTokenResponseSchema,
        data: { refreshToken },
        signal: this.abortController.signal,
        transformResponse: (res) => res,
      });
      return response;
    } catch (error) {
      throw this.handleError(error);
    }
  };

  changePassword = async (
    data: changePasswordParamsType
  ): Promise<messageResponseType> => {
    this.abortController = new AbortController();
    try {
      const response = await this.fetchApi<
        typeof messageResponseSchema,
        messageResponseType
      >({
        method: 'POST',
        url: officerChangePasswordUrl,
        schema: messageResponseSchema,
        data,
        signal: this.abortController.signal,
        transformResponse: (res) => res,
      });
      return response;
    } catch (error) {
      throw this.handleError(error);
    }
  };

  forgotPassword = async (
    data: forgotPasswordParamsType
  ): Promise<messageResponseType> => {
    this.abortController = new AbortController();
    try {
      const response = await this.fetchApi<
        typeof messageResponseSchema,
        messageResponseType
      >({
        method: 'POST',
        url: officerForgotPasswordUrl,
        schema: messageResponseSchema,
        data,
        signal: this.abortController.signal,
        transformResponse: (res) => res,
      });
      return response;
    } catch (error) {
      throw this.handleError(error);
    }
  };

  verifyPasswordOtp = async (
    data: verifyPasswordOtpParamsType
  ): Promise<messageResponseType> => {
    this.abortController = new AbortController();
    try {
      const response = await this.fetchApi<
        typeof messageResponseSchema,
        messageResponseType
      >({
        method: 'POST',
        url: officerVerifyPasswordOtpUrl,
        schema: messageResponseSchema,
        data,
        signal: this.abortController.signal,
        transformResponse: (res) => res,
      });
      return response;
    } catch (error) {
      throw this.handleError(error);
    }
  };

  resetPassword = async (
    data: resetPasswordParamsType
  ): Promise<messageResponseType> => {
    this.abortController = new AbortController();
    try {
      const response = await this.fetchApi<
        typeof messageResponseSchema,
        messageResponseType
      >({
        method: 'POST',
        url: officerResetPasswordUrl,
        schema: messageResponseSchema,
        data,
        signal: this.abortController.signal,
        transformResponse: (res) => res,
      });
      return response;
    } catch (error) {
      throw this.handleError(error);
    }
  };
}

import { AxiosResponse } from 'axios';
import { fCaptchaSiteverifyUrl } from '../../config/apis';
import { getAxiosNormalInstance } from '../../config/axios';
import { Services } from '../../service';
import { fCaptchaVerifySolutionResponseType } from './type';

const sitekey = process.env.NEXT_PUBLIC_FRIENDLY_SITE_KEY;
const secret = process.env.NEXT_PUBLIC_FRIENDLY_CAPTCHA_KEY;

export class FCaptchaService extends Services {
  verifySolution = async (
    solution: string
  ): Promise<fCaptchaVerifySolutionResponseType> => {
    this.abortController = new AbortController();
    try {
      if (sitekey === undefined) {
        throw new Error('FCAPTCHA: No sitekey found in .env file!');
      }
      if (secret === undefined) {
        throw new Error('FCAPTCHA: No secret found in .env file!');
      }
      const response: AxiosResponse<fCaptchaVerifySolutionResponseType> =
        await getAxiosNormalInstance().post(
          fCaptchaSiteverifyUrl,
          {
            solution,
            secret,
            sitekey,
          },
          {
            signal: this.abortController.signal,
          }
        );
      console.log('FCAPTCHA RES: ', response);
      return response.data;
    } catch (error) {
      throw this.handleError(error);
    }
  };
}

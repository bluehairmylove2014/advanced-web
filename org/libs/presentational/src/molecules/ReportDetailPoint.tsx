import { Carousel } from 'react-responsive-carousel';
import CustomImage from '@presentational/atoms/CustomImage';
import CustomButtonIcon from '@presentational/atoms/CustomButtonIcon';
import { ILocationReport } from '@business-layer/services/entities';

function ReportDetailPoint({
  infoPointReport,
  handleClose,
  handleBack,
}: {
  infoPointReport: ILocationReport;
  handleClose: () => void;
  handleBack: () => void;
}) {
  return (
    <div
      className="h-[100%] w-[25%] bg-white shadow-md min-w-[45vh] fixed overflow-y-scroll scrollbar z-40"
      style={{ left: 0, top: 0 }}
    >
      <div className="absolute z-10 top-0 right-0 mt-2 mx-1">
        <CustomButtonIcon
          widthIcon="0.6rem"
          heightIcon="0.6rem"
          type="button"
          bgColor="bg-black/70"
          round={5}
          padding={8}
          pathImage="/assets/close.png"
          alt=""
          onClick={handleClose}
        >
          {' '}
        </CustomButtonIcon>
      </div>

      {/* Back Button */}
      <div className="absolute top-0 left-0 z-10 mt-2 mx-1">
        <CustomButtonIcon
          widthIcon="0.6rem"
          heightIcon="0.6rem"
          type="button"
          pathImage="/assets/undo.png"
          alt=""
          border={1}
          colorBorder="blue"
          round={4}
          onClick={handleBack}
        >
          {' '}
        </CustomButtonIcon>
      </div>

      <div className="mx-3 ">
        <p className="text-center text-[0.9rem] font-bold my-4">BÁO CÁO</p>
        <hr className="my-4" />
        <div className="flex justify-between">
          <p className="text-sky-500 font-bold">Nội dung báo cáo</p>
          <p className="text-rose-600 font-bold text-[0.75rem] ">
            ĐANG XÉT DUYỆT
          </p>
        </div>
        <div className="flex mt-1">
          <i className="fi fi-br-id-card-clip-alt text-sky-500 text-[0.65rem] mr-1"></i>
          <p className="text-[0.7rem] text-neutral-600">
            Họ và tên:
            <span className="font-semibold "> {infoPointReport.name}</span>
          </p>
        </div>

        <div className="flex mt-1">
          <i className="fi fi-sr-envelope text-sky-500 text-[0.65rem] mr-1"></i>
          <p className=" text-xs text-neutral-600">
            Email:
            <span className="font-semibold "> {infoPointReport.email}</span>
          </p>
        </div>

        <div className="flex mt-1">
          <i className="fi fi-sr-phone-call text-sky-500 text-[0.65rem] mr-1"></i>
          <p className=" text-[0.7rem] text-neutral-600">
            Số điện thoại:
            <span className="font-semibold "> {infoPointReport.email}</span>
          </p>
        </div>

        <div className="flex mt-1">
          <i className="fi fi-br-browser text-sky-500 text-[0.65rem] mr-1"></i>
          <p className=" text-[0.7rem] text-neutral-600">
            Hình thức báo cáo:
            <span className="font-semibold ">
              {' '}
              {infoPointReport.reportType}
            </span>
          </p>
        </div>

        <div className="flex mt-1">
          <i className="fi fi-sr-form text-sky-500 text-[0.65rem] mr-1"></i>
          <p className=" text-[0.7rem] text-neutral-600">Nội dung báo cáo:</p>
        </div>
        <div className="h-[30vh] border rounded mt-1 p-1 text-[0.7rem] text-neutral-500">
          <div>{infoPointReport.content}</div>
        </div>

        {Array.isArray(infoPointReport.images) ? (
          infoPointReport.images.length ? (
            <>
              <div className="flex mt-2">
                <i className="fi fi-br-picture text-sky-500 text-[0.65rem] mr-1"></i>
                <p className=" text-[0.7rem] text-neutral-600">
                  Hình ảnh minh chứng:
                </p>
              </div>

              <Carousel showStatus={false} showThumbs={false}>
                {infoPointReport.images.map((data, index) => (
                  <div
                    className="w-[100%] h-[30vh] rounded"
                    key={`carousel@${index}`}
                  >
                    <CustomImage
                      src={data.image}
                      alt="location"
                      width="100%"
                      height="30vh"
                    />
                  </div>
                ))}
              </Carousel>
            </>
          ) : (
            <></>
          )
        ) : (
          <></>
        )}
      </div>

      <hr className="my-4 mx-3" />
      <div className="mx-3 mb-4">
        <p className="text-sky-500 font-bold">Thông tin điểm báo cáo</p>
        {infoPointReport.reportData ? (
          <>
            <div className="flex mt-2">
              <i className="fi fi-sr-marker text-sky-500 text-[0.65rem] mr-1"></i>
              <p className="text-[0.7rem] text-neutral-600">
                Địa chỉ:
                <span className="font-semibold ">
                  {' '}
                  {infoPointReport.reportData.address}
                </span>
              </p>
            </div>
            <div className="flex mt-1">
              <i className="fi fi-sr-settings text-sky-500 text-[0.65rem] mr-1"></i>
              <p className="text-[0.7rem] text-neutral-600">
                Hình thức:
                <span className="font-semibold ">
                  {' '}
                  {infoPointReport.reportData.adsForm}
                </span>
              </p>
            </div>
            <div className="flex mt-1">
              <i className="fi fi-sr-layers text-sky-500 text-[0.65rem] mr-1"></i>
              <p className="text-[0.7rem] text-neutral-600">
                Loại vị trí:
                <span className="font-semibold ">
                  {' '}
                  {infoPointReport.reportData.locationType}
                </span>
              </p>
            </div>
            <div className="flex my-1">
              {infoPointReport.reportData.planned ? (
                <p className="font-bold text-medium ỉtalic text-green-600">
                  ĐÃ QUY HOẠCH
                </p>
              ) : (
                <p className="font-bold text-medium text-rose-600">
                  CHƯA QUY HOẠCH
                </p>
              )}
            </div>
            <Carousel showStatus={false} showThumbs={false}>
              {infoPointReport.reportData.images.map((data, index) => (
                <div
                  className="w-[100%] h-[30vh] rounded"
                  key={`carousel@${index}`}
                >
                  <CustomImage
                    src={data.image}
                    alt="location"
                    width="100%"
                    height="30vh"
                  />
                </div>
              ))}
            </Carousel>
          </>
        ) : (
          <>
            <div className="flex mt-2">
              <i className="fi fi-ss-star text-sky-500 text-[0.65rem] mr-1"></i>
              <p className="text-[0.7rem] text-neutral-600">
                Vĩ độ:
                <span className="font-semibold ">
                  {' '}
                  {infoPointReport.latitude}
                </span>
              </p>
            </div>
            <div className="flex mt-1">
              <i className="fi fi-ss-star text-sky-500 text-[0.65rem] mr-1"></i>
              <p className="text-[0.7rem] text-neutral-600">
                Kinh độ:
                <span className="font-semibold ">
                  {' '}
                  {infoPointReport.longitude}
                </span>
              </p>
            </div>
          </>
        )}
      </div>
    </div>
  );
}

export default ReportDetailPoint;

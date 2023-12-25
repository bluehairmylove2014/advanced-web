import { OFFICER_PAGES } from '@constants/officerPages';
import BellButton from '@presentational/atoms/BellButton';
import OfficerNavAvatar from '@presentational/molecules/OfficerNavAvatar';
import OfficerNavDropdown from '@presentational/molecules/OfficerNavDropdown';
import Image from 'next/image';
import Link from 'next/link';

const officerNavDropdownOptions = [
  {
    name: 'Danh sách cấp phép',
    href: OFFICER_PAGES.APPROVE_LIST,
  },
  {
    name: 'Tạo cấp phép mới',
    href: OFFICER_PAGES.NEW_APPROVE,
  },
];

function OfficerHeader() {
  return (
    <header className="flex flex-row items-center justify-between bg-indigo-950 w-full h-12 px-4 sticky top-0 z-20">
      <nav>
        <ul className="flex flex-row items-center justify-start gap-5">
          <div className=" w-20 h-10 object-cover relative">
            <Link href={OFFICER_PAGES.DASHBOARD}>
              <Image
                src={'/assets/images/logo/white.png'}
                alt="Urashima Ads"
                fill
              />
            </Link>
          </div>
          <li>
            <Link
              href={OFFICER_PAGES.DASHBOARD}
              prefetch={true}
              className="text-xs text-white font-semibold hover:text-orange-400"
            >
              Trang chủ
            </Link>
          </li>
          <li>
            <Link
              href={OFFICER_PAGES.ADS_LOCATION}
              prefetch={true}
              className="text-xs text-white font-semibold hover:text-orange-400"
            >
              Quản lý quảng cáo
            </Link>
          </li>
          <li>
            <Link
              href={OFFICER_PAGES.REPORT}
              prefetch={true}
              className="text-xs text-white font-semibold hover:text-orange-400"
            >
              Danh sách báo cáo
            </Link>
          </li>
          <li>
            <OfficerNavDropdown
              options={officerNavDropdownOptions}
              position="center"
            >
              <span>Cấp phép</span>
            </OfficerNavDropdown>
          </li>
        </ul>
      </nav>
      <div className="flex flex-row justify-end items-center gap-4 hover">
        <BellButton />
        <OfficerNavAvatar />
      </div>
    </header>
  );
}

export default OfficerHeader;

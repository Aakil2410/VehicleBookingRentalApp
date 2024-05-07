import Link from "next/link";
import Image from "next/image";
import { CustomButton } from "../../components";

const Navbar = () => {
  const haveToken = localStorage.getItem("token") !== null;
  return (
    <header className="w-full  absolute z-10">
      <nav className="max-w-[1440px] mx-auto flex justify-between items-center sm:px-16 px-6 py-4 bg-transparent">
        <Link href="/" className="flex justify-center items-center">
          <Image
            src="/logo.jpg"
            alt="logo"
            width={118}
            height={18}
            className="object-contain"
          />
        </Link>

        {!haveToken ? <Link href="/sign-in-or-sign-up" className="flex-center">
          <CustomButton
            title="Sign in"
            btnType="button"
            containerStyles="text-primary-blue rounded-full bg-white min-w-[130px]"
          />
        </Link> : 
        <Link href="/user-dashboard" className="flex-center">
        <CustomButton
          title="My Rentals"
          btnType="button"
          containerStyles="text-primary-blue rounded-full bg-white min-w-[130px]"
        />
      </Link>
        }
        
      </nav>
    </header>
  );
};

export default Navbar;

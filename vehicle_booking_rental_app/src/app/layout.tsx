
import type { Metadata } from "next";
import "./globals.css";
import { Footer, Navbar } from "../../components";


export const metadata: Metadata = {
  title: "Dream Rentals",
  description: "Making dreams of driving your favourite car a reality",
};

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <>
    <html lang="en">
      <body className="relative">
        <Navbar />
        {children}
        <Footer />
      </body>
    </html>
    </>
  );
}

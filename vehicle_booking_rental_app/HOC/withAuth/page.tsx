'use client'
import React from "react";
import { useRouter } from "next/navigation";

const withAuth = (WrappedComponent: React.FC<any>) => {
    const AuthComponent: React.FC<any> = (props) => {
    const haveToken = localStorage.getItem("token") !== null;  
        const {push} = useRouter();
        if (haveToken) {
            return <WrappedComponent {...props} />;
        } else {
            push("../sign-in-or-sign-up")
        }
    };

    return AuthComponent;
};

export default withAuth;
"use client";
import React, { FC, PropsWithChildren, useContext, useReducer } from "react";
import { UserReducer } from "./reducer";
import {
  INITIAL_STATE,
  UserContext,
  UserActionContext,
  IUser,
  ILogin,
  IUserStateContext,
  IUserActionContext,
} from "./context";
import { CREATE_USER, USER_LOGIN, USER_LOGOUT } from "./actions";
import { database } from "../apiInstance";
import { message } from "antd";
import { useRouter } from "next/navigation";

const AuthProvider: FC<PropsWithChildren> = ({ children }) => {
  const [state, dispatch] = useReducer(UserReducer, INITIAL_STATE);
  const { push } = useRouter();

  const loginUser = async (payload: ILogin) => {
    try {
      const response = await database.post(
        `${process.env.NEXT_PUBLIC_PASS}/TokenAuth/Authenticate`,
        payload
      );
      if (response.data.success) {
        localStorage.setItem("token", response.data.result.accessToken);
        dispatch(USER_LOGIN(response.data.result));

        // do check for user type
        if (response.data.result.userId === 1) {
          push("/admin-dashboard");

          message.success(`Welcome`);
        } else {
          push("/user-dashboard");

          message.success("Welcome");
        }
      } else {
        message.error(`${response.data.message} \n ${response.data.details}`);
      }
    } catch (error) {
      console.log(error);
      message.error("Login failed");
    }
  };

  const createUser = async (payload: IUser) => {
    try {
      const response = await database.post(
        `${process.env.NEXT_PUBLIC_PASS}/services/app/Person/Create`,
        payload
      );

      if (response.data.success) {
        message.success(`Hi ${response.data.result.name}. `); // ad more to message
        dispatch(CREATE_USER(response.data.result));
        push("/sign-in"); // try auto login
        message.info("Try logging in");
      } else {
        message.error("Failed to create user");
      }
    } catch (error) {
      console.error("User creation error:", error);
      message.error("Email is already linked to an account.");
    }
  };

  const logoutUser = () => {
    dispatch(USER_LOGOUT());
    localStorage.removeItem("token");
    push("/");
  };

  return (
    <UserContext.Provider value={state}>
      <UserActionContext.Provider value={{ loginUser, createUser, logoutUser }}>
        {children}
      </UserActionContext.Provider>
    </UserContext.Provider>
  );
};

const useLoginState = (): IUserStateContext => {
  const context = useContext(UserContext);
  if (!context) {
    throw new Error("useLoginState must be used within a UserProvider");
  }
  return context;
};

const useLoginActions = (): IUserActionContext => {
  const context = useContext(UserActionContext);
  if (!context) {
    throw new Error("useLoginActions must be used within a UserProvider");
  }
  return context;
};

function UseUsers(): any {
  return {
    ...useLoginState(),
    ...useLoginActions(),
  };
}

export { AuthProvider, UseUsers };

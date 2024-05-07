import { createAction } from "redux-actions";
import { ILogin, IUser, IUserStateContext } from "./context";

export enum UserActionEnum {
    CREATE_USER = 'CREATE_USER',
    USER_LOGIN = 'USER_LOGIN',
    USER_LOGOUT = 'USER_LOGOUT'
}

//                        // < where you want changes to be made >                            //payload        return obj
export const createUserRequestAction = createAction<IUserStateContext, IUser>(UserActionEnum.CREATE_USER, (CreateUser) => ({CreateUser}));
//                                         dest             src

export const loginUserRequestAction = createAction<IUserStateContext, ILogin>(UserActionEnum.USER_LOGIN, (UserLogin) => ({UserLogin}));

export const logoutUserRequestAction = createAction<IUserStateContext>(UserActionEnum.USER_LOGOUT, () => ({}));

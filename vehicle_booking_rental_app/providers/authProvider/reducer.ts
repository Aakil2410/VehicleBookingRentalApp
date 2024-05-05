import { UserActionEnum } from "./actions";
import { IUserStateContext } from "./context";

export function UserReducer(incomingState: IUserStateContext, action: ReduxActions.Action<IUserStateContext>): IUserStateContext {
    const { type, payload } = action;

    switch (type) {
        case UserActionEnum.CREATE_USER:
            return {  ...incomingState, ...payload };

        case UserActionEnum.USER_LOGIN:
            return {  ...incomingState, ...payload };

        case UserActionEnum.USER_LOGOUT:
            return {  ...incomingState, ...payload };
        
        default:
            return incomingState;
    }
}

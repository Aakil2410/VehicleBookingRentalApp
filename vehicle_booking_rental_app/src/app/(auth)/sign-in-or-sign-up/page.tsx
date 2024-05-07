'use client'

import { FC, useState } from "react";
import {
  Form,
  Input,
  Button,
  Select,
  Space,
  DatePicker,
} from "antd";
import { LockOutlined, UserOutlined } from "@ant-design/icons";
import styles from "./style.module.css";
import { UseUsers } from "../../../../providers/authProvider";
import { Navbar } from "../../../../components";
import { ILogin, IUser } from "../../../../providers/authProvider/context";



const SignInSignUp: FC = () => {
  const [activeTab, setActiveTab] = useState<"sign-in" | "sign-up">("sign-in");

  const toggleTab = (tab: "sign-in" | "sign-up") => {
    setActiveTab(tab);
  };

  const { Option } = Select;

  const dateFormat = "DD/MM/YYYY";

  const { loginUser, createUser  } = UseUsers();

  const onSignInFinish = async (values: ILogin) => {
    console.log("Received values:", values);
    console.log(activeTab);
    if (activeTab === "sign-in") {
      if (loginUser) {
        await loginUser(values)
      } else {console.log("n10o")}
    }
  };

  const onSignUpFinish = async (values: IUser) => {
    console.log("Received values:", values);
    
    console.log(activeTab);
    if (activeTab === "sign-up") {
      createUser ? createUser({ ...values }) : console.log("no");
    } else {
      console.log("no no");
    }
  };


  return (
    <>
    <div className={styles.container}>
      <div className={styles["form-container"]}>
        <div className={styles["tab-buttons"]}>
          <button
            className={`${styles["tab-button"]} ${
              activeTab === "sign-in" && styles.active
            }`}
            onClick={() => toggleTab("sign-in")}
          >
            Sign In
          </button>
          <button
            className={`${styles["tab-button"]} ${
              activeTab === "sign-up" && styles.active
            }`}
            onClick={() => toggleTab("sign-up")}
          >
            Sign Up
          </button>
        </div>
        <div className={styles.form}>
          {activeTab === "sign-in" ? (
            <Form
              name="signInForm"
              onFinish={onSignInFinish}
              scrollToFirstError
            >
              <Form.Item
                name="userNameOrEmailAddress"
                rules={[
                  { required: true, message: "Please input your email!" },
                ]}
              >
                <Input
                  prefix={<UserOutlined className="site-form-item-icon" />}
                  placeholder="Email"
                />
              </Form.Item>
              <Form.Item
                name="password"
                rules={[
                  { required: true, message: "Please input your password!" },
                ]}
              >
                <Input
                  prefix={<LockOutlined className="site-form-item-icon" />}
                  type="password"
                  placeholder="Password"
                />
              </Form.Item>
              <Form.Item>
                <Button type="primary" htmlType="submit" className="button">
                  Sign In
                </Button>
              </Form.Item>
            </Form>
          ) : (
            <Form
              name="signUpForm"
              onFinish={onSignUpFinish}
              scrollToFirstError
            >
              <Form.Item
                name="name"
                rules={[{ required: true, message: "Please input your name!" }]}
              >
                <Input placeholder="Name" />
              </Form.Item>

              <Form.Item
                name="surname"
                rules={[
                  { required: true, message: "Please input your surnamename!" },
                ]}
              >
                <Input placeholder="Surname" />
              </Form.Item>

              <Form.Item
                name="gender"
                rules={[{ required: true, message: "Please select gender!" }]}
              >
                <Select placeholder="select your gender">
                  <Option value="1">Male</Option>
                  <Option value="2">Female</Option>
                  <Option value="3">Other</Option>
                  <Option value="4">Prefer not to say</Option>
                </Select>
              </Form.Item>

              <Space direction="horizontal" size={12}>
                Date of birth:
                <DatePicker
                  //defaultValue={("DD/MM/YYYY")}
                  format={dateFormat}
                />
              </Space>
              <br />

              <Form.Item
                name="idNumber"
                rules={[
                  {
                    required: true,
                    message: "Please input your valid SouthAfrican ID number!",
                  },
                ]}
              >
                <Input placeholder="Valid South African ID Number" />
              </Form.Item>

              <Form.Item
                name="contactNumber"
                rules={[
                  {
                    required: true,
                    message: "Please input your contact number!",
                  },
                ]}
              >
                <Input placeholder="Contactc Number" />
              </Form.Item>

              <Form.Item
                name="address"
                rules={[
                  { required: true, message: "Please input your address!" },
                ]}
              >
                <Input placeholder="Address" />
              </Form.Item>

              <Form.Item
                name="email"
                rules={[
                  { required: true, message: "Please input your email!" },
                ]}
              >
                <Input
                  prefix={<UserOutlined className="site-form-item-icon" />}
                  placeholder="Email"
                />
              </Form.Item>

              <Form.Item
                name="password"
                rules={[
                  {
                    required: true,
                    message: "Please input your password!",
                  },
                ]}
                hasFeedback
              >
                <Input.Password 
                prefix={<LockOutlined className="site-form-item-icon" />}
                type="password"
                placeholder="Password"/>
              </Form.Item>

              <Form.Item
                name="confirm"
                dependencies={["password"]}
                hasFeedback
                rules={[
                  {
                    required: true,
                    message: "Please confirm your password!",
                  },
                  ({ getFieldValue }) => ({
                    validator(_, value) {
                      if (!value || getFieldValue("password") === value) {
                        return Promise.resolve();
                      }
                      return Promise.reject(
                        new Error(
                          "The new password that you entered do not match!"
                        )
                      );
                    },
                  }),
                ]}
              >
                <Input.Password 
                prefix={<LockOutlined className="site-form-item-icon" />}
                type="password"
                placeholder="Confirm password"/>
              </Form.Item>

              
              <Form.Item>
                <Button type="primary" htmlType="submit">
                  Sign Up
                </Button>
              </Form.Item>
            </Form>
          )}
        </div>
      </div>
    </div>
    </>
  );
};

export default SignInSignUp;

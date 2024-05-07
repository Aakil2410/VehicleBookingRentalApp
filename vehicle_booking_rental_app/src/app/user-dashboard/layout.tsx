'use client'
import React, { useState } from 'react';
import type { MenuProps } from 'antd';
import { Breadcrumb, Layout, Mentions, Menu, theme } from 'antd';
import Link from 'next/link';
import withAuth from '../../../HOC/withAuth/page';

const { Header, Content, Footer, Sider } = Layout;

type MenuItem = Required<MenuProps>['items'][number];

function getItem(
  label: React.ReactNode,
  key: React.Key,
  icon?: React.ReactNode,
  children?: MenuItem[],
): MenuItem {
  return {
    key,
    icon,
    children,
    label,
  } as MenuItem;
}

const navLinks = [
  { name: "My current rentals", href: "./" },
  { name: "Book a vehicle", href: "./user-dashboard/booking" },
  { name: "History", href: "./" },
  { name: "Logout", href: "/", onclick: () => {localStorage.removeItem("token")}}
];


const AdminLayout= ({
    children,
  }: Readonly<{
    children: React.ReactNode;
  }>) => {
  const [collapsed, setCollapsed] = useState(false);
  const {
    token: { colorBgContainer, borderRadiusLG },
  } = theme.useToken();

  return (
    <Layout style={{ minHeight: '100vh'}}>
      <Sider collapsible collapsed={collapsed} onCollapse={(value) => setCollapsed(value)}>
        <div className="demo-logo-vertical" />
        <Menu theme="dark" mode="inline" defaultSelectedKeys={['0']}>
            {navLinks.map((link, index) => (
              <Menu.Item key={index}>
                <Link href={link.href}>{link.name}</Link>
              </Menu.Item>
            ))}
          </Menu>
      </Sider>
      <Layout>
        {/* <Header style={{ padding: 0, background: colorBgContainer, border: '1px solid' }} />
         */}
        <Content style={{ margin: '15px' }}>
          <h1>Dream Rentals</h1>
          <div
            style={{
              padding: 24,
              minHeight: 360,
              background: colorBgContainer,
              borderRadius: borderRadiusLG,
            }}
          > 
          {children}
          </div>
        </Content>
        <Footer style={{ textAlign: 'center' }}>
          LMS
        </Footer>
      </Layout>
    </Layout>
  );
};

export default withAuth(AdminLayout);
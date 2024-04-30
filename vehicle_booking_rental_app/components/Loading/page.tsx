import React from 'react';
import { Alert, Flex, Spin } from 'antd';
import styles from './Loading.module.css';

const Loading: React.FC = () => (
  <> <br/><br/><br/><br/><br/><br/><br/><br/> 
  <Flex gap="small" vertical>
    
    <Flex gap="large">

      <Spin tip="Loading" size="large">
        <div className={styles.content} />
      </Spin>
    </Flex>

  </Flex></>
);

export default Loading;
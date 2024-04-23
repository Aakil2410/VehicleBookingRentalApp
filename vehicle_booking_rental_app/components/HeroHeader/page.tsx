'use client'
import { Button } from 'antd'
import React from 'react'

const HeroHeader = () => {

    const handleScroll = () => {


    }


  return (
    <div className='hero'>
      <div className='flex-1 pt-36 padding-x'>
        <h1 className='hero_title'>Rent a damn car</h1>
      </div>

      <p className='hero_subtitle'>The best place for easy booking of rental vehicles </p>

    <Button 
    className='width-20' 
    onClick = {handleScroll}
    >Explore Cars</Button>
    </div>
  )
}

export default HeroHeader

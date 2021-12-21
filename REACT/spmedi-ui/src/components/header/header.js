import React from 'react'
import Logo from '../../assets/img/logo.png'

export default function Header(){

    return(
        <header>
            <img src={Logo} className="Logo"/>
            <nav className="BarraHeader">
            </nav>
        </header>
    )
}
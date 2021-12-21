import React from 'react'
import { Component } from 'react';
import axios from 'axios';
import { parseJwt, usuarioAutenticado } from '../../services/auth';
import { Link } from 'react-router-dom';
import '../../assets/css/home.css';
import Logo from '../../assets/img/logo_spmedi.png';
import Header from '../../components/header/header';
import Footer from '../../components/footer/footer';


export default class App extends Component {
  constructor(props) {
      super(props);
      this.state = {
          email: '',
          senha: '',
          erroMensagem: '',
          isLoading: false
      };
  };

  EfetuaLogin = (evento) => {
    evento.preventDefault();

    this.setState({ erroMensagem: '', isLoading: true });

    axios.post("http://localhost:5000/api/Login", {
        email: this.state.email,
        senha: this.state.senha
    })

    .then(resposta => {
        if (resposta.status === 200) {

            localStorage.setItem("usuario-login", resposta.data.token);

            this.setState({ isLoading: false});

            switch (parseJwt().role) {
                case "1":
                    this.props.history.push("/administrador")
                    console.log("estou logado: " + usuarioAutenticado())
                    break;

                case "2":
                    this.props.history.push("/medico")
                    console.log("estou logado: " + usuarioAutenticado())
                    break;

                case "3":
                    this.props.history.push("/paciente")
                    console.log("estou logado: " + usuarioAutenticado())
                    break;
            
                default:
                    this.props.history.push("/")
                    break;
            }
        }
    }).catch( erro => console.log(erro), this.setState({ erroMensagem: "credenciais inválidas"}))

}


  atualizaStateCampo = (campo) => {

    this.setState({ [campo.target.name]: campo.target.value })
  };
  
  render(){
    return (
      <>
        <Header/>
        <main>
          <section className="telainicio">
              <div className="itenscentro">
                  <img src={Logo} className="LogoInicio"/>
                  <h1>Clínica Paulista</h1>
                  <h2>SP Medical Group</h2>
              </div>
              <div className="login">
                  <span className="login_text">Login</span>
                  <form className="form_login" onSubmit={this.EfetuaLogin}>
                      <input className= "input_email" type="Email" name="email" onChange={this.atualizaStateCampo}/>
                      <input className= "input_senha" type="password" name="senha" onChange={this.atualizaStateCampo}/>
                      <button type="submit" className="botao">Entrar</button>
                  </form>
              </div>
          </section>
        </main>

        <Footer/>
      </>
    );
  }
}

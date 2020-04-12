import React, {useState} from 'react';
import {Link, useHistory} from 'react-router-dom';
import {FiArrowLeft} from 'react-icons/fi';

import './styles.css';

import logoImg from '../../assets/logo192.png';

import api from '../../services/api';

export default function New() {
   const [cpf, setCpf] = useState('');
   const [nome, setNome] = useState('');
   const [nascimento, setNascimento] = useState('');
   const [empresa, setEmpresa] = useState('');
   const history = useHistory();

   async function handleNewclient(e) {
      e.preventDefault();
      const data = {
         cpf,
         nome,
         nascimento,
         empresa,
      };
      try {
         var result = await api.post('cliente', data, {
            headers: {
               Authorization: 'apptoken',
            },
         });
         alert('Cliente cadastrado com sucesso');
         history.push('/cliente/list');
      } catch (error) {
         alert('Erro ao cadastrar o cliente.');
      }
   }

   return (
      <div className="new-client-container">
         <div className="content">
            <section>
               <img src={logoImg} alt="WebApp" width={100} />
               <h1>Cadastrar cliente</h1>
               <p>Cadastre corretamente os dados do cliente</p>
               <Link className="back-link" to="/cliente/list">
                  <FiArrowLeft size={16} color="#E02041"></FiArrowLeft>
                  Voltar
               </Link>
            </section>
            <form onSubmit={handleNewclient}>
               <input
                  placeholder="CPF"
                  value={cpf}
                  onChange={(e) => setCpf(e.target.value)}></input>
               <input
                  placeholder="Nome"
                  value={nome}
                  onChange={(e) => setNome(e.target.value)}></input>
               <input
                  type="date"
                  placeholder="Nascimento"
                  value={nascimento}
                  onChange={(e) => setNascimento(e.target.value)}></input>
               <input
                  placeholder="Empresa"
                  value={empresa}
                  onChange={(e) => setEmpresa(e.target.value)}></input>
               <button className="button">Cadastrar</button>
            </form>
         </div>
      </div>
   );
}

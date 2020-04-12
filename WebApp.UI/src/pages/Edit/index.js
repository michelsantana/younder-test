import React, {useState, useEffect} from 'react';
import {Link, useHistory, useParams} from 'react-router-dom';
import {FiArrowLeft} from 'react-icons/fi';

import './styles.css';

import logoImg from '../../assets/logo192.png';

import api from '../../services/api';

export default function Edit() {
   const [cpf, setCpf] = useState('');
   const [nome, setNome] = useState('');
   const [nascimento, setNascimento] = useState('');
   const [empresa, setEmpresa] = useState('');
   const history = useHistory();
   const params = useParams();
   const clientId = params.id;

   useEffect(() => {
      api.get(`cliente/${clientId}`, {
         headers: {
            Authorization: 'apptoken',
         },
      }).then((result) => {
         const client = result.data;
         setCpf(client.cpf);
         setNome(client.nome);
         setNascimento(client.nascimento);
         setEmpresa(client.empresa);
      });
   }, [cpf, params, clientId]);

   async function handleEditClient(e) {
      e.preventDefault();
      const data = {
         cpf,
         nome,
         nascimento,
         empresa,
      };
      try {
         var result = await api.put(`cliente/${clientId}`, data);
         alert('Cliente salvo com sucesso.');
         history.push('/cliente/list');
      } catch (error) {
         alert('Erro ao editar o cliente.');
      }
   }

   return (
      <div className="new-client-container">
         <div className="content">
            <section>
               <img src={logoImg} alt="WebApp" width={100} />
               <h1>Editar cliente</h1>
               <p>Revise os dados do cliente</p>
               <Link className="back-link" to="/cliente/list">
                  <FiArrowLeft size={16} color="#E02041"></FiArrowLeft>
                  Voltar
               </Link>
            </section>
            <form onSubmit={handleEditClient}>
               <input
                  placeholder="CPF"
                  value={cpf}
                  maxLength="11"
                  required
                  onChange={(e) => setCpf(e.target.value)}></input>
               <input
                  placeholder="Nome"
                  value={nome}
                  maxLength="100"
                  required
                  onChange={(e) => setNome(e.target.value)}></input>
               <input
                  type="date"
                  placeholder="Nascimento"
                  value={nascimento}
                  required
                  onChange={(e) => setNascimento(e.target.value)}></input>
               <input
                  placeholder="Empresa"
                  value={empresa}
                  maxLength="100"
                  required
                  onChange={(e) => setEmpresa(e.target.value)}></input>
               <button className="button">Salvar</button>
            </form>
         </div>
      </div>
   );
}

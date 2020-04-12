import React, {useState, useEffect} from 'react';
import {Link, useHistory} from 'react-router-dom';
import {FiTrash2, FiEdit} from 'react-icons/fi';

import './styles.css';

import logoImg from '../../assets/logo192.png';

import api from '../../services/api';

export default function List() {
   const [clients, setClients] = useState([]);
   const [controlApi, setControlApi] = useState(0);
   const history = useHistory();

   useEffect(() => {
      api.get('cliente', {
         headers: {
            Authorization: 'apptoken',
         },
      }).then((result) => {
         setClients(result.data);
      });
   }, [controlApi]);

   async function handleDeleteClient(id) {
      try {
         await api.delete(`cliente/${id}`, {
            headers: {
               Authorization: 'apptoken',
            },
         });
         setClients(clients.filter((client) => client.id !== id));
         alert('Caso excluido com sucesso.');
      } catch (err) {
         alert('Erro ao excluir');
      }
   }

   async function handleEditClient(id) {
      history.push(`/cliente/edit/${id}`);
   }

   return (
      <div className="client-container">
         <header>
            <img src={logoImg} alt="WebApp" width={70} />
            <span>Bem vindo ao sistema WebApp</span>
            <Link className="button" to="/cliente/new">
               Cadastrar novo cliente
            </Link>
         </header>
         <h3>Clientes cadastrados</h3>
         <ul>
            {clients.map((client) => (
               <li key={client.id}>
                  <strong>CPF</strong>
                  <p>{client.cpf}</p>
                  <strong>Nome</strong>
                  <p>{client.nome}</p>
                  <strong>Data de nascimento</strong>
                  <p>
                     {Intl.DateTimeFormat('pt-BR').format(
                        new Date(client.nascimento)
                     )}
                  </p>
                  <strong>Empresa</strong>
                  <p>{client.empresa}</p>
                  <div className="btn-group">
                     <button onClick={() => handleDeleteClient(client.id)}>
                        <FiTrash2 size={20} color="#a8a8b3"></FiTrash2>
                     </button>
                     <button onClick={() => handleEditClient(client.id)}>
                        <FiEdit size={20} color="#a8a8b3"></FiEdit>
                     </button>
                  </div>
               </li>
            ))}
         </ul>
      </div>
   );
}

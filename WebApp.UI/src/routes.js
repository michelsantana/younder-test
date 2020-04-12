import React from 'react';
import { BrowserRouter, Route, Switch } from 'react-router-dom';

import List from './pages/List';
import Edit from './pages/Edit';
import New from './pages/New';
// import Register from './pages/Register';
// import Profile from './pages/Profile';
// import NewIncident from './pages/NewIncident';

export default function Routes(){
    return(
        <BrowserRouter>
            <Switch>
                <Route path="/" exact component={List} />
                <Route path="/cliente/list" component={List} />
                <Route path="/cliente/new" component={New} />
                <Route path="/cliente/edit/:id" component={Edit} />
            </Switch>
        </BrowserRouter>
    ); 
}
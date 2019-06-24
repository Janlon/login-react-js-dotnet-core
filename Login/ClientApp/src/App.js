import React, { Component } from 'react';
import { Route } from 'react-router';
// import { Layout } from './components/Layout';
import { Home } from './components/Home';
// import { FetchData } from './components/FetchData';
// import { Counter } from './components/Counter';

export default class App extends Component {
  //static displayName = App.name;

  render () {
    return (
      // <Layout>
      <div>
        <Route exact path='/' component={Home} />
      </div>
        /* <Route path='/counter' component={Counter} /> */
        /* <Route path='/fetch-data' component={FetchData} /> */
      // </Layout>
    );
  }
}

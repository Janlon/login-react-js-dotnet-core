import React, { Component } from 'react';
import './Home.css';

export class Home extends Component {

  SigIn(data, api) {

   // var CryptoJS = require("crypto-js");
 
    // Encrypt
   // var ciphertext = CryptoJS.AES.encrypt(JSON.stringify(data), 'secret key 123');
    //var encrypted = ciphertext.toString();
    //console.log(encrypted);

    fetch(api,{
      method:'POST',
      headers:{ 'Content-Type': 'application/json' },
      //body:JSON.stringify({data:encrypted})
      body:JSON.stringify({data})
    })
    .then((response) => response.json())
    .then((responseJson) => { 

      // // Decrypt
      // var bytes  = CryptoJS.AES.decrypt(responseJson.toString(), 'secret key 123');
      // var plaintext = bytes.toString(CryptoJS.enc.Utf8);
      // //console.log(plaintext)

      this.setState({message:responseJson.message});

      //retorno do token 
      console.log(responseJson.accessToken)
     })
    .catch((error) => { console.error(error); });
  }
  
  constructor (props) {
    super(props);
    this.state = {
        username: '',
        password: '',
        message: ''
    };
  }

  handleChange = (e) => {
    this.setState({ [e.target.name]: e.target.value })
  }

  onSubmit = (e) => {
    e.preventDefault();

   if(this.state.username !== '' && this.state.password !== '')
   {
    var data = {
      UserID: this.state.username,   
      Password: this.state.password
    }
    const url = 'https://localhost:5001/api/logins';

    this.SigIn(data, url);
   }

    this.setState({
          username: '',
          password: '',
          message: ''
    })
  }

  render () {
    return (
      <div id="login">
        <h1>SIGN IN<span className="orangestop">.</span></h1>
        <p>
          <span className="reg">{this.state.message}</span>
        </p>
        <span className="input">
          <span className="icon username-icon fontawesome-user" />
          <input type="text" id="username" name="username" className="username" placeholder="Username" value={this.state.username} onChange={e => this.handleChange(e)} />
        </span>
        <span className="input">
          <span className="password-icon-style icon password-icon fontawesome-lock" />
          <input type="password" id="password" name="password" className="password" placeholder="Password" value={this.state.password} onChange={e => this.handleChange(e)} />
        </span>
        <div className="forgot">Forgot Details?</div>
        <div className="divider" />
        <button onClick={(e) => this.onSubmit(e)} >Log In</button>
        <p>Don't have an account? 
          <span className="reg">Register.</span>
        </p>
      </div>
    );
  }


}

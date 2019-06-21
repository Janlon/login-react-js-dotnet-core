import React from 'react';
import './App.css';


function App() {
    return (
      <div id="login">
        <h1>SIGN IN<span className="orangestop">.</span></h1>
        <span className="input">
          <span className="icon username-icon fontawesome-user" />
          <input type="text" className="username" placeholder="Username" />
        </span>
        <span className="input">
          <span className="password-icon-style icon password-icon fontawesome-lock" />
          <input type="password" className="password" placeholder="Password" />
        </span>
        <div className="forgot">Forgot Details?</div>
        <div className="divider" />
        <button onClick = {() => {SigIn()}}>Log In</button>
        <p>Don't have an account? 
          <span className="reg">Register.</span>
        </p>
      </div>
  );
}

function SigIn() {


  var headers = new Headers();
  const url = "http://localhost:5000/api/login";
  const data = { "UserID": "admin_api", "Password": "Admin_api123" };

//   headers.append('Content-Type', 'application/json');
//   headers.append('Accept', 'application/json');
//   headers.append('Origin','http://localhost:3000');
//   headers.append('Access-Control-Allow-Origin', '*')
//   headers.append("Access-Control-Allow-Methods", "DELETE, POST, GET, OPTIONS")
//   headers.append("Access-Control-Allow-Headers", "Content-Type, Access-Control-Allow-Headers, Authorization, X-Requested-With")

fetch(url, {
  headers : { 
    'Content-Type': 'application/json',
    'Accept': 'application/json',
    'Access-Control-Allow-Origin': '*'
   },
   method: 'Post',
   body: JSON.stringify(data)
})
.then((response) => response.json())
.then((messages) => {console.log("messages");});
}

// function ooSigIn(){
//  // var username = document.getElementsByClassName('username')[0].value;
//  // var password = document.getElementsByClassName('password')[0].value;
//   const data = { "UserID": "admin_api", "Password": "Admin_api123" }
//  // const proxyurl = "https://cors-anywhere.herokuapp.com/";
//   const url = "https://localhost:5001/api/login"; // site that doesn’t send Access-Control-*
//   const requestInfo = {
//     method: 'Post',
//     body: JSON.stringify(data),
//     headers: new Headers({
//       'Content-Type':'application/json',
//       'Origin':'http://localhost:3000'
//     }),  
//   };

 
//    fetch(url, requestInfo)
//   .then(response => response.text())
//   .then(contents => console.log(contents))
//   .catch(() => console.log("Site bloqueado"))
// }

export default App;

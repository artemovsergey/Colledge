import { useState } from 'react'
import { BrowserRouter as Router, Route, Routes  } from 'react-router-dom';
import Home from './src/components/home'
import Header from './src/components/header'
import Login from './src/components/login'
import "./src/components/App.css"


function App() {

  return (
    <Router>
        <Header/>
        <div className="container mt-5">
            <Routes>
                <Route path="/home" element={<Home />} />
                <Route path="/login" element={<Login />} />
                <Route path="/" element={<Home />} />                
            </Routes>
    
        </div>  
    </Router>
  )
}

export default App

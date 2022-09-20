import React from "react";
import{Route, Switch} from "react-router-dom";
import Homepage from './pages/Homepage';
import LoginPage from './pages/Login';
import DetailPage from './pages/DetailPage';
import Navigation from "./Components/Navigation";
import "antd/dist/antd.css";
import  Categories  from "./Components/Categories";

function App() {
  return (
  <> 
  <Navigation />
  <Route exact path="/" component={Categories} />
    <Switch> 
      <Route exact path="/" component={Homepage} />
        <Route exact path="/login" component={LoginPage} />
      <Route exact path="/detail" component={DetailPage} />
    </Switch>
  </>
  );
}

export default App;

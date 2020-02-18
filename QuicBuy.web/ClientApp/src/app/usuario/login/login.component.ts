import { Component} from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { Router } from "@angular/router";

@Component ({
    selector: "app-login",
    templateUrl: "./login.component.html",
    styleUrls: ["./login.component.css"]
})

  export class LoginComponent{
    public usuario;

    constructor(private router: Router) {
        this.usuario = new Usuario();
      
    }

    entrar() {
      if(this.usuario.email == ""){
      sessionStorage.setItem("usuario-autenticado","1");
      // this.router.navigate(['/']);
      }

    }
  }



//IMAGEM PARA FUNDO: https://img.olhardigital.com.br/uploads/acervo_imagens/2019/03/r16x9/20190315121922_1200_675_-_compras_online_e_commerce.jpg

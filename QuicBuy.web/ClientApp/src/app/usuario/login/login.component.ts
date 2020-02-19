import { Component} from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { Router, ActivatedRoute } from "@angular/router";
import { UsuarioServico } from "../../servicos/usuario/usuario.servico";

@Component ({
    selector: "app-login",
    templateUrl: "./login.component.html",
    styleUrls: ["./login.component.css"]
})

  export class LoginComponent{
    public usuario;

    constructor(private router: Router, private activatedRouter: ActivatedRoute, private usuarioServico: UsuarioServico) {
        this.usuario = new Usuario();
      
    }

    entrar() {
      this.usuarioServico.verificarUsuario(this.usuario)
      .subscribe(
        data=> {

        }
        // error =>{

        // }
      );
    }
  }



//IMAGEM PARA FUNDO: https://img.olhardigital.com.br/uploads/acervo_imagens/2019/03/r16x9/20190315121922_1200_675_-_compras_online_e_commerce.jpg

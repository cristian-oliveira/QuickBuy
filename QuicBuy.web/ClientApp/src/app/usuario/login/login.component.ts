import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { Router, ActivatedRoute } from "@angular/router";
import { UsuarioServico } from "../../servicos/usuario/usuario.servico";
@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent implements OnInit {
  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.usuario = new Usuario();
  }
  public usuario;
  public returnUrl: string;
  public mensagem: string;

  constructor(private router: Router, private activatedRouter: ActivatedRoute, private usuarioServico: UsuarioServico) {
  }

  entrar() {
    this.usuarioServico.verificarUsuario(this.usuario)
      .subscribe(
        usuario_json => {

        var usuarioRetorno: Usuario; //linha executada em execucao sem erros
        this.usuarioServico.usuario = usuario_json;
        // usuarioRetorno = usuario_json;

        if (this.returnUrl == null) {
          this.router.navigate(['/']);
        } else {
          this.router.navigate([this.returnUrl]);
        }      
      }, err => {
        console.log(err.error);
        this.mensagem = err.error;
      });
  }
}

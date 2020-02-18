import { Component} from "@angular/core";
import { Usuario } from "../../modelo/usuario";

@Component ({
    selector: "app-login",
    templateUrl: "./login.component.html",
    styleUrls: ["./login.component.css"]
})

export class LoginComponent{
  public usuario = new Usuario();
  public email = "";
  //public endImg = "C:/Users/Dell/Desktop/Nova pasta/QuickBuy/QuicBuy.web/ClientApp/src/assets/imgs/banner-best-buy-260nw-713290624.jpg";
  //public titulo = "Titulo adicionado";
  entrar() {
    // alert();
  }
}


//IMAGEM PARA FUNDO: https://img.olhardigital.com.br/uploads/acervo_imagens/2019/03/r16x9/20190315121922_1200_675_-_compras_online_e_commerce.jpg

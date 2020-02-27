import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Usuario } from "../../modelo/usuario";


@Injectable({
  providedIn: 'root'
})

export class UsuarioServico {

  private baseURL: string;
  private _usuario: Usuario;

  get usuario(): Usuario {

  }

  set usuario(usuario: Usuario){

  }

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }

  public verificarUsuario (usuario: Usuario): Observable<Usuario> {
    const headers = new HttpHeaders().set('content-type','application/json');
    
    var body ={
      email:usuario.email,
      senha:usuario.senha
    }
    return this.http.post<Usuario>("https://localhost:44305/api/Usuario/verificarUsuario", usuario, { headers });//BASEURL indica a raiz do site
   
  }

}

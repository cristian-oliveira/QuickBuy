import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Usuario } from "../../modelo/usuario";


@Injectable({
  providedIn: "root"
})


export class UsuarioServico {

  private baseURL: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string {
    this.baseURL = baseUrl;

  }

   public verificarUsuario (usuario: Usuario): Observable<Usuario> {
     this.http.
  }
}

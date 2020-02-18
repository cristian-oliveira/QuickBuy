import { Injectable } from "@angular/core";
import { Router, CanActivate } from "@angular/router";
@Injectable({
  providedIn: 'root' //publica GuardaRotas na raiz
})
export class GuardaRotas implements CanActivate {
  constructor(private router: Router) {
  }
  canActivate(route: import("@angular/router").ActivatedRouteSnapshot, state: import("@angular/router").RouterStateSnapshot) {
    var autenticacao = sessionStorage.getItem("usuario-autenticado");
    if (autenticacao === "1") {
      return true;
    }
    // this.router.navigate(['/entrar'], {queryParams: { returnUrl:state.url}}); //navegar para pagina de autenticacao caso usuario nao seja cadastrado 
    // se usuario foi autenticado


    this.router.navigate(['/entrar'], { queryParams: { returnUrl: state.url } }); //navegar para pagina de autenticacao caso usuario nao seja cadastrado 
    //return false; // se usuario foi autenticado


  }
}

import { Component } from '@angular/core';
import { Router } from '@angular/router';
//import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

  constructor(private router: Router){
    
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
  public usuarioLogado() : boolean {

      return sessionStorage.getItem("usuario-autenticado") == "1";
  }
  

  sair(){
    sessionStorage.setItem("usuario-autenticado", "");
    this.router.navigate(['/']);
  }
}

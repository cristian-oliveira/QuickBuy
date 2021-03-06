import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
// import { HomeComponent } from './home/home.component';
// import { CounterComponent } from './counter/counter.component';
// import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ProdutoCompenent } from './produto/produto.component';
import { LoginComponent } from './usuario/login/login.component';
import { GuardaRotas } from "./autorizacao/GuardaRotas";
import { UsuarioServico } from './servicos/usuario/usuario.servico';
import { CadastroUsuarioComponent } from './usuario/cadastro/cadastro.usuario.component';
import { ProdutoServico } from './servicos/produto/produto.servico';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    // HomeComponent,
    // CounterComponent,
    // FetchDataComponent,
    ProdutoCompenent,
    LoginComponent,
    CadastroUsuarioComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      // { path: '', component: HomeComponent, pathMatch: 'full' },
      // { path: 'counter', component: CounterComponent },
      // { path: 'fetch-data', component: FetchDataComponent },
      { path: 'produto', component: ProdutoCompenent},
      { path: 'entrar', component: LoginComponent },
      { path: 'novo-usuario', component:CadastroUsuarioComponent  }

    ])
  ],
  providers: [UsuarioServico,ProdutoServico], 
  bootstrap: [AppComponent]
})
export class AppModule { }
// { path: 'produto', component: ProdutoCompenent, canActivate:[GuardaRotas] },

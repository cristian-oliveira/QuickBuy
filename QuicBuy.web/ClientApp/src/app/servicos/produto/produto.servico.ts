import { Injectable, Inject} from "@angular/core"
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Produto } from "src/app/modelo/produto";

@Injectable({
    providedIn: "root"
})

export class ProdutoServico {
  
    private _baseUrl: string;
    public produtos: Produto[];

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this._baseUrl = baseUrl;
    }
    
    public cadastrar(produto: Produto): Observable<Produto>{   
        const headers = new HttpHeaders().set('content-type','application/json');
        return this.http.post<Produto>(this._baseUrl + "/api/produto/cadastrar", produto, { headers });//BASEURL indica a raiz do site
    }

    public salvar(produto: Produto): Observable<Produto>{   
        const headers = new HttpHeaders().set('content-type','application/json');
        return this.http.post<Produto>(this._baseUrl + "/api/produto/salvar", produto, { headers });
    }

    public deletar(produto: Produto): Observable<Produto>{   
        const headers = new HttpHeaders().set('content-type','application/json');
        return this.http.post<Produto>(this._baseUrl + "/api/produto/deletar", produto, { headers });
    }

    public obterTodosProdutos(): Observable<Produto[]>{ 
        return this.http.get<Produto[]>(this._baseUrl + "/api/produto/obterTodosProdutos");
    }

    public obterProduto(): Observable<Produto>{ 
        return this.http.get<Produto>(this._baseUrl + "/api/produto/obter");
    }
    public enviarArquivo(arquivoSelecionado: File) : Observable<string>{
        const formData: FormData = new FormData();
        formData.append("arquivoEnviado",arquivoSelecionado,arquivoSelecionado.name);
        return this.http.post<string>("https://localhost:44305/api/Produto/enviarArquivo",formData);

      }

}

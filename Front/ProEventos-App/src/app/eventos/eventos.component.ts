import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos : any = [];
  public eventosFiltrados: any =[];
  imagewidth :number = 150;
  imageheight:number = 100;
  imagemmargin:number = 2;
  isCollapsed = true;
  private _filtrolista : string = '';

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getEventos();
  }

  public get filtrolista():string {
    return this._filtrolista;
  }

  public set filtrolista(value:string){

    this._filtrolista = value;
    this.eventosFiltrados = this.filtrolista ? this.getEventosFiltrados(this.filtrolista) : this.eventos;
  }

  public getEventos(): void{

    this.http.get('https://localhost:5001/api/Eventos').subscribe(
      response => {this.eventos = response,
      this.eventosFiltrados = this.eventos},
      error => console.log("Erro:", error)
    );

  }

  public getEventosFiltrados(filtrarPor :string) : any{
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.eventos.filter(
      ( evento: { tema: string; local: string; }) => evento.tema.toLocaleLowerCase().indexOf(filtrarPor)!== -1 ||
      evento.local.toLocaleLowerCase().indexOf(filtrarPor)!== -1 );
  }



}

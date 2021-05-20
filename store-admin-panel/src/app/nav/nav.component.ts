import { Component, OnInit } from '@angular/core';
import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import { Observable } from 'rxjs';
import { map, shareReplay } from 'rxjs/operators';
import { ApiService } from '../api.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.scss']
})
export class NavComponent implements OnInit {

  isHandset$: Observable<boolean> = this.breakpointObserver.observe(Breakpoints.Handset)
    .pipe(
      map(result => result.matches),
      shareReplay()
    );

  //menuItems = ['dashboard', 'sales', 'orders', 'customers', 'products'];
  menuItems: string[] = [];
  pageHeader: string = "store admin panel";

constructor(private breakpointObserver: BreakpointObserver, private apiService: ApiService) {}

ngOnInit() {
  this.apiService.getLeftNav().subscribe(result => {
    this.menuItems = result;
  })
}
}

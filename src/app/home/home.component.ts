import { Component } from '@angular/core';
import { NgbCollapseModule } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [NgbCollapseModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent {
  isMenuCollapsed = true;
}

import { Routes, RouterModule } from '@angular/router';
import { MainComponent } from './main/main.component';
import { ModuleWithProviders } from '@angular/core';

const routes: Routes = [
  { path: '', component: MainComponent },
];
export const AppRoutingModule: ModuleWithProviders = RouterModule.forRoot(routes);


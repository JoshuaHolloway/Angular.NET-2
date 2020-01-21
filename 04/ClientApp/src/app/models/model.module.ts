import { NgModule, NgModule } from '@angular/core';
import { Repository } from './repository';

@NgModule({
  // used to register classes for dependency injection
  providers: [Repository]
})
export class ModelModule { }

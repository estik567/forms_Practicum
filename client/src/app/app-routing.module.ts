import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddChildComponent } from './add-child/add-child.component';
import { AddUserComponent } from './add-user/add-user.component';
import { InstructionsForFillComponent } from './instructions-for-fill/instructions-for-fill.component';

const routes: Routes = [
   {path:"add-user" ,component:AddUserComponent},
   {path:"add-child" ,component:AddChildComponent},
   {path:"fillForm" ,component:InstructionsForFillComponent},
   {path:"" ,component:InstructionsForFillComponent}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

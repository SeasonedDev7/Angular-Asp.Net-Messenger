import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';
import { RouterModule } from '@angular/router';
import { FormBuilderModule } from 'src/app/shared/form-builder/form-builder.module';
import { CreateAccountFormComponent } from './create-account-form.component';

@NgModule({
  declarations: [CreateAccountFormComponent],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    MatFormFieldModule,
    MatInputModule,
    MatIconModule,
    MatButtonModule,
    RouterModule,
    FormBuilderModule,
  ],
  exports: [CreateAccountFormComponent]
})
export class CreateAccountFormModule { }

import { NgModule } from '@angular/core';
import {Routes, RouterModule } from '@angular/router'

import { CategoriasComponent } from './categorias/categorias.component';
import { CategoriaDetalheComponent } from './categoria-detalhe/categoria-detalhe.component';
import { CategoriaNovaComponent } from './categoria-nova/categoria-nova.component';
import { CategoriaEditarComponent } from './categoria-editar/categoria-editar.component';
import { ProdutosComponent } from './produtos/produtos.component';
import { ProdutoDetalheComponent } from './produto-detalhe/produto-detalhe.component';
import { ProdutoNovoComponent } from './produto-novo/produto-novo.component';
import { ProdutoEditarComponent } from './produto-editar/produto-editar.component';
import { LoginComponent } from './login/login.component';
import { LogoutComponent } from './logout/logout.component';

const routes : Routes = [
    {
    path: 'login',
    component: LoginComponent,
    data: {title:'Login'}
    },
    {
        path: 'logout',
        component: LogoutComponent,
        data: {title:'Logout'}
    },
    {
        path: 'categorias',
        component: CategoriasComponent,
        data: {title:'Categorias'}
    },
    {
        path: 'categoria-detalhe/:id',
        component: CategoriaDetalheComponent,
        data: {title:'Detalhe da Categoria'}
    },
    {
        path: 'categoria-nova',
        component: CategoriaNovaComponent,
        data: {title:'Adicionar Categoria'}
    }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule {}
import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProdutoEditarComponent } from './produto-editar.component';

describe('ProdutoEditarComponent', () => {
  let component: ProdutoEditarComponent;
  let fixture: ComponentFixture<ProdutoEditarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProdutoEditarComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProdutoEditarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

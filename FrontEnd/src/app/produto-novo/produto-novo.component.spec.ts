import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProdutoNovoComponent } from './produto-novo.component';

describe('ProdutoNovoComponent', () => {
  let component: ProdutoNovoComponent;
  let fixture: ComponentFixture<ProdutoNovoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProdutoNovoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProdutoNovoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

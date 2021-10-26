import { Component } from 'react';

export default class Desejos extends Component {
  constructor(props) {
    super(props);
    this.state = {
      listaDesejos : [],
      descricao : '',
      idDesejo : 0,
      idUsuario : 0
    }
  }

  ListarDesejos = () => {
    
    fetch('http://localhost:5000/api/Desejos')

    .then(resposta => resposta.json())

    .then(dados => this.setState({ listaDesejos: dados }))

    .catch(erro => console.log(erro))
  }

  CadastrarDesejo = (event) => {

    event.preventDefault()

    fetch('http://localhost:5000/api/Desejos', {

    method: 'POST',

    body: JSON.stringify({ 
      descricao: this.state.descricao,
      idUsuario: this.state.idUsuario
    }), 

    headers: { "Content-Type": "application/json" }
    })

    .then(console.log("Desejo cadastrado."))

    .catch(erro => console.log(erro))

    .then(this.ListarDesejos)
  }

  AtualizarDesricao = async (event) => {
    //Nome titulo > valor input.
    await this.setState({ descricao: event.target.value })
    console.log(this.state.descricao)
}

AtualizarId = async (event) => {
  //Nome titulo > valor input.
  await this.setState({ idUsuario: event.target.value })
  console.log(this.state.idUsuario)
}

  componentDidMount() {
    this.ListarDesejos();
  }

  render() {
    return (
      <div>
        <main>
          <section>
            <h1>Cadastro</h1>
            <form onSubmit={this.CadastrarDesejo}>
              <div>
                <input 
                type="text"
                value={this.state.descricao}
                placeholder="Desejo"
                onChange={this.AtualizarDesricao}
                ></input>
                <input 
                type="number"
                value={this.state.idUsuario}
                placeholder="Id Usuario"
                onChange={this.AtualizarId}
                ></input>
              </div>
              <button 
              className=""
              type="submit"
              disabled={this.state.idUsuario === 0 || this.state.descricao === '' ? 'none' : ''}
              >Cadastrar</button>
            </form>
          </section>
          <section>
            <table>
              <thead>
                <th>Id</th>
                <th>Desejo</th>
              </thead>

              <tbody>
                {
                  this.state.listaDesejos.map((desejo) => {
                    return (
                      <tr key={desejo.idDesejo}>
                        <td>{desejo.idDesejo}</td>
                        <td>{desejo.descricao}</td>
                      </tr>
                    )
                  })
                }
              </tbody>
            </table>
          </section>
        </main>
      </div>
    )
  }

}


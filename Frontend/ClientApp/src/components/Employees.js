import React, { Component } from 'react';

export class Employees extends Component {
    static displayName = "Employees";

    constructor(props) {
        super(props);
        this.state = { employees: [], loading: true };
    }

    componentDidMount() {
        this.populateWeatherData();
    }

    populateWeatherData = async () => {
        const response = await fetch('api/employees');
        const data = await response.json();
        this.setState({ idEmployee: "", employees: data, loading: false });
    }

    searchEmployee = async () => {
        const response = await fetch(`api/employees/${this.state.idEmployee}`);
        const data = await response.json();
        this.setState({ employees: data, loading: false });
    }

    setEmployeeId = (event) => {
        debugger;
        this.setState({ idEmployee: event.target.value, loading: false });
    }

    static renderEmployeesTable(employees) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                        <th>Contract Type</th>
                        <th>Role Name</th>
                        <th>Annual Salary</th>
                    </tr>
                </thead>
                <tbody>
                    {employees.map(employee =>
                        <tr key={employee.id}>
                            <td>{employee.id}</td>
                            <td>{employee.name}</td>
                            <td>{employee.contractTypeName}</td>
                            <td>{employee.roleName}</td>
                            <td>{employee.annualSalary}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Employees.renderEmployeesTable(this.state.employees);

        return (
            <div>
                <h1 id="tabelLabel" >Employees</h1>
                <div className="row">
                    <div className="input-group mb-3">
                        <input onChange={this.setEmployeeId} type="number" className="form-control" placeholder="Write id employee" aria-label="Id employee" aria-describedby="basic-addon2"/>
                            <div className="input-group-append">
                            <button onClick={this.searchEmployee} className="btn btn-outline-secondary" type="button">Get Employees</button>
                            </div>
                    </div>
                </div>
                {contents}
            </div>
        );
    }

}

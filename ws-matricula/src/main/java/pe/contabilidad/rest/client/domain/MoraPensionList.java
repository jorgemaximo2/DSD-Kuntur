package pe.contabilidad.rest.client.domain;

import java.util.List;

import javax.xml.bind.annotation.XmlRootElement;

import pe.contabilidad.rest.client.domain.MoraPension;

@XmlRootElement(name="alumnos")
public class MoraPensionList {
	
	public List<MoraPension> getData() {
		return data;
	}

	public void setData(List<MoraPension> data) {
		this.data = data;
	}

	private List<MoraPension> data;

}

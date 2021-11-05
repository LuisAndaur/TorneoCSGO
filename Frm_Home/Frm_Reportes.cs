﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_TorneoPRO;

namespace Frm_TorneoPRO
{
    public partial class Frm_Reportes : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        SaveFileDialog saveFile = new SaveFileDialog();

        public Frm_Reportes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Precarga los datos necesarios antes de abrir el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Estadistica_Load(object sender, EventArgs e)
        {
            this.openFile.Filter = "Text Files |*.txt|Json File |*.json|Xml Files |*.xml";
            this.saveFile.Filter = "Text Files |*.txt|Json File |*.json|Xml Files |*.xml";
        }

        /// <summary>
        /// Vuelve al home
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Reporta el campeon del torneo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception_Archivo">Error en guardar archivo txt</exception>
        /// <exception cref="Exception_SerializacionJson">Error en serializacion o deserializacion de un json</exception>
        /// <exception cref="Exception_SerializacionXml">Error en serializacion o deserializacion de un xml</exception>
        private void btn_Campeon_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarComo(Jugador.Campeon());
                Mensaje();
            }
            catch (Exception_Archivo eArchivo)
            {
                MessageBox.Show(eArchivo.Message, "ERROR al guardar txt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception_SerializacionJson eSerializacionJson)
            {
                MessageBox.Show(eSerializacionJson.Message, "ERROR al guardar json", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception_SerializacionXml eSerializacionXml)
            {
                MessageBox.Show(eSerializacionXml.Message, "ERROR al guardar xml", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception auxEx)
            {
                MessageBox.Show(auxEx.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Reporta como salio cada jugador en el torneo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception_Archivo">Error en guardar archivo txt</exception>
        /// <exception cref="Exception_SerializacionJson">Error en serializacion o deserializacion de un json</exception>
        /// <exception cref="Exception_SerializacionXml">Error en serializacion o deserializacion de un xml</exception>
        private void btn_EstadisticaJugadores_Click(object sender, EventArgs e)
        {            
            try
            {
                GuardarComo(TorneoPro.ListaJugadores);
                Mensaje();
            }
            catch (Exception_Archivo eArchivo)
            {
                MessageBox.Show(eArchivo.Message, "ERROR al guardar txt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception_SerializacionJson eSerializacionJson)
            {
                MessageBox.Show(eSerializacionJson.Message, "ERROR al guardar json", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception_SerializacionXml eSerializacionXml)
            {
                MessageBox.Show(eSerializacionXml.Message, "ERROR al guardar xml", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception auxEx)
            {
                MessageBox.Show(auxEx.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Abre la opcion para poner el nombre, elegir la extension y guardar el archivo en la ruta seleccionada
        /// </summary>
        /// <param name="tipo">Nombre del parametro</param>
        private void GuardarComo(Jugador tipo)
        {
            this.saveFile.ShowDialog();
            if (this.saveFile.FileName != String.Empty)
            {
                if (Path.GetExtension(this.saveFile.FileName) == ".txt")
                {
                    try
                    {
                        Archivo<Jugador>.Escribir(tipo, this.saveFile.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Path.GetExtension(this.saveFile.FileName) == ".json")
                {
                    try
                    {
                        SerializacionJson<Jugador>.Escribir(tipo, this.saveFile.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Path.GetExtension(this.saveFile.FileName) == ".xml")
                {
                    try
                    {
                        SerializacionXml<Jugador>.Escribir(tipo, this.saveFile.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.openFile.FileName = this.saveFile.FileName;
            }
        }

        /// <summary>
        /// Abre la opcion para poner el nombre, elegir la extension y guardar el archivo en la ruta seleccionada
        /// </summary>
        /// <param name="tipo">Nombre del parametro</param>
        private void GuardarComo(List<Jugador> tipo)
        {
            this.saveFile.ShowDialog();
            if (this.saveFile.FileName != String.Empty)
            {
                if (Path.GetExtension(this.saveFile.FileName) == ".txt")
                {
                    try
                    {
                        Archivo<List<Jugador>>.Escribir(TorneoPro.Imprimir(tipo), this.saveFile.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Path.GetExtension(this.saveFile.FileName) == ".json")
                {
                    try
                    {
                        SerializacionJson<List<Jugador>>.Escribir(tipo, this.saveFile.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Path.GetExtension(this.saveFile.FileName) == ".xml")
                {
                    try
                    {
                        SerializacionXml<List<Jugador>>.Escribir(tipo, this.saveFile.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.openFile.FileName = this.saveFile.FileName;
            }
        }

        private void Mensaje()
        {
            Frm_Mensaje mensaje = new Frm_Mensaje("Archivo guardado\nEXITOSAMENTE!");
            mensaje.ShowDialog();
        }

    }
}
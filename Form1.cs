using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MuniVD_Geo.Clases;

namespace MuniVD_Geo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //GeoLocalizacion

        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        PointLatLng inicio;
        PointLatLng final;

        GMarkerGoogleType gmapHabilitado;

        //double LatInicial = -31.942867;
        //double LngInicial = -65.190201;

        #region Método que configura el mapar de Geolocalización

        private void ConfigurarMapaGeoL(DataTable coordenadas)
        {
            

            // Creamos un overlay para los marcadores.
            GMapOverlay markerOverlay = new GMapOverlay("Marcador");

            // Recorremos el DataTable para agregar los marcadores.
            foreach (DataRow row in coordenadas.Rows)
            {
                // Extraemos la latitud y longitud de cada fila del DataTable.
                double latitud = Convert.ToDouble(row["Latitud"]);
                double longitud = Convert.ToDouble(row["Longitud"]);

                int bHabilitado = Convert.ToInt32(row["IdCondicion"]);

                

                switch(bHabilitado)
                {
                    case 1:
                        gmapHabilitado = GMarkerGoogleType.green;
                        break;

                    case 2:
                        gmapHabilitado = GMarkerGoogleType.yellow;
                        break;

                    case 3:
                        gmapHabilitado = GMarkerGoogleType.red;
                        break;

                    case 4:
                        gmapHabilitado = GMarkerGoogleType.blue;
                        break;
                }

                // Creamos el marcador para cada coordenada.
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(latitud, longitud), gmapHabilitado);

                // Añadimos un tooltip con la información del punto.
                //marker.ToolTipMode = MarkerTooltipMode.Always;
                //marker.ToolTipText = string.Format("Ubicación:\n Latitud: {0}\n Longitud: {1}", latitud, longitud);

                // Añadimos el marcador al overlay.
                markerOverlay.Markers.Add(marker);
            }

            // Agregamos el overlay con los marcadores al mapa.
            gMapControl1.Overlays.Add(markerOverlay);

            // Si el DataTable tiene filas, ajustamos la posición inicial del mapa al primer punto.
            if (coordenadas.Rows.Count > 0)
            {
                double latInicial = Convert.ToDouble(coordenadas.Rows[0]["Latitud"]);
                double lngInicial = Convert.ToDouble(coordenadas.Rows[0]["Longitud"]);
                gMapControl1.Position = new PointLatLng(latInicial, lngInicial);
            }

            // Actualizamos el control de mapa.
            gMapControl1.Refresh();
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuramos las propiedades básicas del mapa.
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 12;  // Ajusta el zoom según tus necesidades.
            gMapControl1.AutoScroll = true;

            

            double LatInicial = -31.942867;
            double LngInicial = -65.190201;

            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);

            
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string sMyCad = "select * from Vista_Comercios";
            DataTable myDt = clsMetodos.GetSql(sMyCad);

            ConfigurarMapaGeoL(myDt);
        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
        }

        private void btnRelieve_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleTerrainMap;
        }

        private void btnSatelite_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleSatelliteMap;
        }

        private void trackZoom_ValueChanged(object sender, EventArgs e)
        {
            gMapControl1.Zoom = trackZoom.Value;
        }
    }
}

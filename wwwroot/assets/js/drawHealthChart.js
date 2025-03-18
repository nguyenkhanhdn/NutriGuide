const { al } = require("../vendor/chart.js/chunks/helpers.segment");

function drawChart() {
    var url = "/api/healthrecordapis/1";
    console.log("Fetching data from:", url); // Debug URL
    var data1 = null;
    var data2 = null;
    var data3 = null;
    fetch(url)
        .then(response => {
            if (!response.ok) {
                throw new Error("Network response was not ok");
            }
            return response.json();
        })
        .then(data => {
            console.log("Received Data:", data); // Debug dữ liệu nhận được


            if (!Array.isArray(data) || data.length === 0) {
                console.error("No data received!");
                return;
            }

            // Xử lý dữ liệu
            const xx = data.map(item => item.Date);
            const bloodSugar = data.map(item => item.BloodSugar);
            data1 = bloodSugar;
            console.log("Blood Sugar:", bloodSugar);
            const systolicBP = data.map(item => item.SystolicBP);
            data2 = systolicBP;

            const diastolicBP = data.map(item => item.DiastolicBP);
            data3 = diastolicBP;
        });
    alert(data1);
        document.addEventListener("DOMContentLoaded", () => {
            new Chart(document.querySelector('#lineChart'), {
                type: 'line',
                data: {
                    labels: data1,
                    datasets: [
                        {
                            label: 'Chỉ số đường trong máu',
                            data: data2,
                            fill: false,
                            borderColor: 'rgb(75, 192, 192)',
                            tension: 0.1
                        },
                        {
                            label: 'Chỉ số',
                            data: data3,
                            fill: false,
                            borderColor: 'rgb(255, 99, 132)',
                            tension: 0.1
                        }
                    ]
                },
                options: {
                    responsive: true,
                    maintainAspectRatio: false,
                    scales: {
                        y: {
                            beginAtZero: true
                        }
                    }
                }
            });
        });

}
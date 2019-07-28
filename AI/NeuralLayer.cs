﻿using System.Collections.Generic;
using System.Linq;

namespace Se7en.AI {

    public class NeuralLayer {
        public List<INeuron> Neurons;

        public NeuralLayer() => Neurons = new List<INeuron>();

        /// <summary>
        /// Connecting two layers.
        /// </summary>
        public void ConnectLayers(NeuralLayer inputLayer) {


            foreach (var input in Neurons) {
                foreach (var output in inputLayer.Neurons) {
                    input.AddInputNeuron(output);
                }
            }
            //foreach (var item in Neurons.SelectMany(neuron => inputLayer.Neurons, (neuron, input) => new { neuron, input })) {
                //item.neuron.AddInputNeuron(item.neuron);
            //}
        }
    }
}
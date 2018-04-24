using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GCIEL.Toolkit
{
    
    public class QuantityTrigger : MonoBehaviour {

        [SerializeField]
        GameEvent ResultingEvent;
        [SerializeField]
        IntReference Threshold;
        [SerializeField]
        IntReference TrackedMeasure;

        /// <summary>
        /// Triggers ResultingEvent when the tracked variable >= threshold
        /// </summary>
        public void CheckThresholdGEQ ()
        {
            if (TrackedMeasure.Value >= Threshold.Value)
            {
                ResultingEvent.Raise();
            }
        }

        /// <summary>
        /// Triggers ResultingEvent when the tracked variable > threshold
        /// </summary>
        public void CheckThresholdGT()
        {
            if (TrackedMeasure.Value > Threshold.Value)
            {
                ResultingEvent.Raise();
            }
        }

        /// <summary>
        /// Triggers ResultingEvent when the tracked variable <= threshold
        /// </summary>
        public void CheckThresholdLEQ()
        {
            if (TrackedMeasure.Value <= Threshold.Value)
            {
                ResultingEvent.Raise();
            }
        }

        /// <summary>
        /// Triggers ResultingEvent when the tracked variable < threshold
        /// </summary>
        public void CheckThresholdLT()
        {
            if (TrackedMeasure.Value < Threshold.Value)
            {
                ResultingEvent.Raise();
            }
        }
    }
}

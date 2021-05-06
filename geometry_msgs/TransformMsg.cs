using System.Collections;
using System.Text;
using SimpleJSON;

/**
 * Define a geometry_msgs pose message. This has been hand-crafted from the corresponding
 * geometry_msgs message file.
 * 
 * @author Miquel Massot Campos
 */

namespace ROSBridgeLib
{
    namespace geometry_msgs
    {
        public class TransformMsg : ROSBridgeMsg
        {
            public Vector3Msg _translation;
            public QuaternionMsg _rotation;

            public TransformMsg(JSONNode msg)
            {
                _translation = new Vector3Msg(msg["translation"]);
                _rotation = new QuaternionMsg(msg["rotation"]);
            }

            public TransformMsg(Vector3Msg p, QuaternionMsg q)
            {
                _translation = p;
                _rotation = q;
            }

            public static string getMessageType()
            {
                return "geometry_msgs/Transform";
            }

            public Vector3Msg GetTranslation()
            {
                return _translation;
            }

            public QuaternionMsg GetRotation()
            {
                return _rotation;
            }

            public override string ToString()
            {
                return "geometry_msgs/Transform [translation=" + _translation.ToString() + ",  rotation=" + _rotation.ToString() + "]";
            }

            public override string ToYAMLString()
            {
                return "{\"translation\": " + _translation.ToYAMLString() + ", \"rotation\": " + _rotation.ToYAMLString() + "}";
            }
        }
    }
}

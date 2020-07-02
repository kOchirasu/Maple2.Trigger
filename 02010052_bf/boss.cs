namespace Maple2.Trigger._02010052_bf {
    public static class _boss {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 4, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {6801, 6802, 6803, 6804, 6805, 6806, 6807, 6808, 6809, 6810, 6811, 6812, 6813, 6814, 6815, 6816, 6817, 6818, 6819, 6820, 6821, 6822, 6823, 6824, 6825, 6826, 6827, 6828, 6829, 6830, 6831, 6832, 6833, 6834, 6835, 6836, 6837, 6838, 6839, 6840, 6841, 6842, 6843, 6844, 6845, 6846, 6847, 6848, 6849, 6850, 6851, 6852, 6853, 6854, 6855, 6856, 6857, 6858, 6859, 6860, 6861, 6862, 6863, 6864, 6865, 6866, 6867, 6868, 6869, 6870, 6871, 6872, 6873, 6874, 6875, 6876, 6877, 6878, 6879, 6880, 6881, 6882, 6883, 6884, 6885, 6886, 6887, 6888, 6889, 6890, 6891, 6892, 6893, 6894, 6895, 6896, 6897, 6898, 6899, 6900}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {7031, 7032, 7033, 7034, 7035, 7999, 7910, 7911, 7912}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 750) == 1) {
                    return new StateEcho(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetPortal(arg1: 5, arg2: true, arg3: true, arg4: true);
            }
        }

        private class StateEcho : TriggerState {
            internal StateEcho(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7800}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 720) == 1) {
                    return new StateBoss_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_01 : TriggerState {
            internal StateBoss_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7531}, arg2: true);
                context.SetMesh(arg1: new[] {6801, 6802, 6803, 6804, 6805, 6806, 6807, 6808, 6809, 6810}, arg2: true, arg3: 80, arg4: 70, arg5: 8f);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateBoss_01b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_01b : TriggerState {
            internal StateBoss_01b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7910}, arg2: true);
                context.CreateMonster(arg1: new[] {995}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateBoss_01c(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_01c : TriggerState {
            internal StateBoss_01c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 200, textId: 20105201);
                context.SetConversation(arg1: 1, arg2: 995, arg3: "$02010052_BF__BOSS__0$", arg4: 3, arg5: 0);
                context.CreateMonster(arg1: new[] {120}, arg2: false);
                context.CreateMonster(arg1: new[] {621, 622, 623, 624, 625}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {120})) {
                    return new StateBurn_state_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBurn_state_01 : TriggerState {
            internal StateBurn_state_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 200);
                context.SetEffect(arg1: new[] {7507}, arg2: true);
                context.SetMesh(arg1: new[] {6801, 6802, 6803, 6804, 6805, 6806, 6807, 6808, 6809, 6810}, arg2: false, arg3: 800, arg4: 100, arg5: 0f);
                context.SetMesh(arg1: new[] {600003}, arg2: false, arg3: 800, arg4: 100, arg5: 0f);
                context.SetEffect(arg1: new[] {7910}, arg2: true);
                context.DestroyMonster(arg1: new[] {995});
                context.SetEventUI(arg1: 1, arg2: "$02010052_BF__BOSS__1$", arg3: 3000);
                context.SetEffect(arg1: new[] {7031}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateBoss_02_idle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_02_idle : TriggerState {
            internal StateBoss_02_idle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 721) == 1) {
                    return new StateBoss_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_02 : TriggerState {
            internal StateBoss_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7532}, arg2: true);
                context.SetMesh(arg1: new[] {6821, 6822, 6823, 6824, 6825, 6826, 6827, 6828, 6829, 6830}, arg2: true, arg3: 80, arg4: 70, arg5: 8f);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateBoss_02b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_02b : TriggerState {
            internal StateBoss_02b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7911}, arg2: true);
                context.CreateMonster(arg1: new[] {996}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateBoss_02c(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_02c : TriggerState {
            internal StateBoss_02c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 200, textId: 20105201);
                context.SetConversation(arg1: 1, arg2: 996, arg3: "$02010052_BF__BOSS__2$", arg4: 3, arg5: 0);
                context.CreateMonster(arg1: new[] {121}, arg2: false);
                context.CreateMonster(arg1: new[] {631, 632, 633, 634, 635}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {121})) {
                    return new StateBurn_state_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBurn_state_02 : TriggerState {
            internal StateBurn_state_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 200);
                context.SetEffect(arg1: new[] {7508}, arg2: true);
                context.SetMesh(arg1: new[] {6821, 6822, 6823, 6824, 6825, 6826, 6827, 6828, 6829, 6830}, arg2: false, arg3: 800, arg4: 100, arg5: 0f);
                context.SetMesh(arg1: new[] {600004}, arg2: false, arg3: 800, arg4: 100, arg5: 0f);
                context.SetEffect(arg1: new[] {7911}, arg2: true);
                context.DestroyMonster(arg1: new[] {996});
                context.SetEventUI(arg1: 1, arg2: "$02010052_BF__BOSS__3$", arg3: 3000);
                context.SetEffect(arg1: new[] {7032}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateBoss_03_idle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_03_idle : TriggerState {
            internal StateBoss_03_idle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 722) == 1) {
                    return new StateBoss_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_03 : TriggerState {
            internal StateBoss_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7533}, arg2: true);
                context.SetMesh(arg1: new[] {6830, 6831, 6832, 6833, 6834, 6835, 6836, 6837, 6838, 6839, 6840}, arg2: true, arg3: 80, arg4: 70, arg5: 8f);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateBoss_03b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_03b : TriggerState {
            internal StateBoss_03b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7912}, arg2: true);
                context.CreateMonster(arg1: new[] {997}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateBoss_03c(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_03c : TriggerState {
            internal StateBoss_03c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 200, textId: 20105201);
                context.SetConversation(arg1: 1, arg2: 997, arg3: "$02010052_BF__BOSS__4$", arg4: 3, arg5: 0);
                context.CreateMonster(arg1: new[] {641, 642, 643, 644, 645}, arg2: true);
                context.CreateMonster(arg1: new[] {122}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {122})) {
                    return new StateBurn_state_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBurn_state_03 : TriggerState {
            internal StateBurn_state_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 200);
                context.SetEffect(arg1: new[] {7509}, arg2: true);
                context.SetMesh(arg1: new[] {6830, 6831, 6832, 6833, 6834, 6835, 6836, 6837, 6838, 6839, 6840}, arg2: false, arg3: 800, arg4: 100, arg5: 0f);
                context.SetMesh(arg1: new[] {600005}, arg2: false, arg3: 800, arg4: 100, arg5: 0f);
                context.SetEffect(arg1: new[] {7912}, arg2: true);
                context.DestroyMonster(arg1: new[] {997});
                context.SetEventUI(arg1: 1, arg2: "$02010052_BF__BOSS__5$", arg3: 3000);
                context.SetEffect(arg1: new[] {7033}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 724) == 1) {
                    return new StateBoss_04_idle(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {123, 124}, arg2: false);
            }
        }

        private class StateBoss_04_idle : TriggerState {
            internal StateBoss_04_idle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 200, textId: 20105201);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {123})) {
                    return new StateBoss_04_idle_A(context);
                }

                if (context.MonsterDead(arg1: new[] {124})) {
                    return new StateBoss_04_idle_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_04_idle_A : TriggerState {
            internal StateBoss_04_idle_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7034}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {124})) {
                    return new StateBurn_state_04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {7035}, arg2: true);
            }
        }

        private class StateBoss_04_idle_B : TriggerState {
            internal StateBoss_04_idle_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7035}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {123})) {
                    return new StateBurn_state_04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {7034}, arg2: true);
            }
        }

        private class StateBurn_state_04 : TriggerState {
            internal StateBurn_state_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 200);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetEffect(arg1: new[] {7999}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 21800073, arg3: "$02010052_BF__BOSS__6$", arg4: 5);
                context.SetSkip(arg1: "Boss_Battle");
                context.SetMesh(arg1: new[] {6201, 6202, 6203, 6204, 6205, 6206, 6207, 6208, 6209, 6210, 6211, 6212, 6213, 6214, 6215, 6216, 6217, 6218, 6219, 6220, 6221, 6222, 6223, 6224, 6225, 6226, 6227, 6228, 6229, 6230, 6231, 6232, 6233, 6234, 6235, 6236, 6237, 6238, 6239, 6240, 6241, 6242, 6243, 6244, 6245, 6246, 6247, 6248, 6249, 6250, 6251, 6252, 6253, 6254, 6255, 6256, 6257, 6258, 6259, 6260, 6261, 6262, 6263, 6264, 6265, 6266, 6267, 6268, 6269, 6270, 6271, 6272, 6273, 6274, 6275, 6276, 6277, 6278, 6279, 6280, 6281, 6282, 6283, 6284, 6285, 6286, 6287, 6288, 6289, 6290, 6291, 6292, 6293, 6294, 6295, 6296, 6297, 6298, 6299, 6300, 6301, 6302, 6303, 6304, 6305, 6306, 6307, 6308, 6309, 6310, 6311, 6312, 6313, 6314, 6315, 6316, 6317, 6318, 6319, 6320, 6321, 6322, 6323, 6324, 6325, 6326, 6327, 6328, 6329, 6330, 6331, 6332, 6333, 6334, 6335, 6336, 6337, 6338, 6339, 6340, 6341, 6342, 6343, 6344, 6345, 6346, 6347, 6348, 6349, 6350, 6351, 6352, 6353, 6354, 6355, 6356, 6357, 6358, 6359, 6360, 6361, 6362, 6363, 6364, 6365, 6366, 6367, 6368, 6369, 6370, 6371, 6372, 6373, 6374, 6375, 6376, 6377, 6378, 6379, 6380, 6381, 6382, 6383, 6384, 6385, 6386, 6387, 6388, 6389, 6390, 6391, 6392, 6393, 6394, 6395, 6396, 6397, 6398, 6399, 6400, 6401, 6402, 6403, 6404, 6405, 6406, 6407, 6408, 6409, 6410, 6411, 6412, 6413, 6414, 6415, 6416, 6417, 6418, 6419, 6420, 6421, 6422, 6423, 6424, 6425, 6426, 6427, 6428, 6429, 6430, 6431, 6432, 6433, 6434, 6435, 6436, 6437, 6438, 6439, 6440, 6441, 6442, 6443, 6444, 6445, 6446, 6447, 6448, 6449, 6450, 6451, 6452, 6453, 6454, 6455, 6456, 6457, 6458, 6459, 6460, 6461, 6462, 6463, 6464, 6465, 6466, 6467, 6468, 6469, 6470, 6471, 6472, 6473, 6474, 6475, 6476, 6477, 6478, 6479, 6480, 6481, 6482, 6483, 6484, 6485, 6486, 6487, 6488, 6489, 6490, 6491, 6492, 6493, 6494, 6495, 6496, 6497, 6498, 6499, 6500, 6501, 6502, 6503, 6504, 6505, 6506, 6507, 6508, 6509, 6510, 6511, 6512, 6513, 6514, 6515, 6516, 6517, 6518, 6519, 6520, 6521, 6522, 6523, 6524, 6525, 6526, 6527, 6528, 6529, 6530, 6531, 6532, 6533, 6534, 6535, 6536, 6537, 6538, 6539, 6540, 6541, 6542, 6543, 6544, 6545, 6546, 6547, 6548, 6549, 6550, 6551, 6552, 6553, 6554, 6555, 6556, 6557, 6558, 6559, 6560, 6561, 6562, 6563, 6564, 6565, 6566, 6567, 6568, 6569, 6570, 6571, 6572, 6573, 6574, 6575, 6576, 6577, 6578, 6579, 6580, 6581, 6582, 6583, 6584, 6585, 6586, 6587, 6588, 6589, 6590, 6591, 6592, 6593, 6594, 6595, 6596, 6597, 6598, 6599, 6600, 6601, 6602, 6603, 6604, 6605, 6606, 6607, 6608, 6609, 6610, 6611, 6612, 6613, 6614, 6615, 6616, 6617, 6618, 6619, 6620, 6621, 6622, 6623, 6624, 6625, 6626, 6627, 6628, 6629, 6630, 6631, 6632, 6633, 6634, 6635, 6636, 6637, 6638, 6639, 6640, 6641, 6642, 6643, 6644, 6645, 6646, 6647, 6648, 6649, 6650, 6651, 6652, 6653, 6654, 6655, 6656, 6657, 6658, 6659, 6660, 6661, 6662, 6663, 6664, 6665, 6666, 6667, 6668, 6669, 6670, 6671, 6672, 6673, 6674, 6675, 6676, 6677, 6678, 6679, 6680, 6681, 6682, 6683, 6684, 6685, 6686, 6687, 6688, 6689, 6690, 6691, 6692, 6693, 6694, 6695, 6696, 6697, 6698, 6699}, arg2: false, arg3: 80, arg4: 10, arg5: 0f);
                context.CameraSelectPath(arg1: new[] {80004, 80005}, arg2: true);
                context.SetTimer(arg1: "6", arg2: 6, arg3: true, arg4: false);
                context.CreateMonster(arg1: new[] {998}, arg2: false);
                context.MoveNpc(arg1: 998, arg2: "MS2PatrolData_1008");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    return new StateBoss_battle_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetMesh(arg1: new[] {6890, 6891, 6892, 6893, 6894, 6895}, arg2: true, arg3: 50, arg4: 70, arg5: 0f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetCinematicUI(arg1: 7);
            }
        }

        private class StateBoss_battle_01 : TriggerState {
            internal StateBoss_battle_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6701, 6702, 6703, 6704, 6705, 6706, 6707, 6708, 6709, 6710, 6711, 6712, 6713, 6714, 6715, 6716, 6717, 6718, 6719, 6720, 6721, 6722, 6723, 6724, 6725, 6726, 6727, 6728, 6729, 6730, 6731, 6732, 6733, 6734, 6735, 6736, 6737, 6738, 6739, 6740, 6741, 6742, 6743, 6744, 6745, 6746, 6747, 6748, 6749, 6750, 6751, 6752, 6753, 6754, 6755, 6756, 6757, 6758, 6759, 6760, 6761, 6762, 6763, 6764, 6765, 6766, 6767, 6768, 6769, 6770, 6771, 6772, 6773, 6774, 6775, 6776, 6777, 6778, 6779, 6780, 6781, 6782, 6783, 6784, 6785, 6786, 6787, 6788, 6789, 6790, 6791, 6792, 6793, 6794, 6795, 6796, 6797, 6798, 6799}, arg2: false, arg3: 80, arg4: 50, arg5: 0f);
                context.SetEventUI(arg1: 1, arg2: "$02010052_BF__BOSS__7$", arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 723) == 1) {
                    return new StateBoss_Spawn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_Spawn_01 : TriggerState {
            internal StateBoss_Spawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {998});
                context.CreateMonster(arg1: new[] {999}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {999})) {
                    return new StateClear_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear_01 : TriggerState {
            internal StateClear_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 80006, arg2: true);
                context.CreateMonster(arg1: new[] {9998}, arg2: false);
                context.SetEffect(arg1: new[] {7998}, arg2: true);
                context.MoveNpc(arg1: 9998, arg2: "MS2PatrolData_1009");
                context.SetConversation(arg1: 2, arg2: 21800073, arg3: "$02010052_BF__BOSS__8$", arg4: 4);
                context.SetTimer(arg1: "5", arg2: 5, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateClear(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetCinematicUI(arg1: 7);
                context.SetEffect(arg1: new[] {7998}, arg2: true);
                context.DestroyMonster(arg1: new[] {9998});
                context.CameraSelect(arg1: 80006, arg2: false);
            }
        }

        private class StateClear : TriggerState {
            internal StateClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6890, 6891, 6892, 6893, 6894, 6895}, arg2: false, arg3: 80, arg4: 10, arg5: 0f);
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
                context.DungeonClear();
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
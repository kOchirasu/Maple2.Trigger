namespace Maple2.Trigger._02020098_bf {
    public static class _bossspawn {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 20, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 30, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 6501, 6502, 6503, 6504, 6505, 6506, 6507, 6508, 6509, 6510, 6511, 6512, 6513, 6514, 6515, 6516, 6517, 6518, 6519, 6520, 6521, 6522, 6523, 6524, 6525, 6526, 6527, 6528, 6529, 6530, 6531, 6532, 6533, 6534, 6535, 6536, 6537, 6538, 6539, 6540, 6541, 6542, 6543, 6544, 6545, 6546, 6547, 6548, 6549, 6550, 6551, 6552, 6553, 6554, 6555, 6556, 6557, 6558, 6559, 6560, 6561, 6562, 6563, 6564, 6565, 6566, 6567, 6568, 6569, 6570, 6571, 6572, 6573, 6574, 6575, 6576, 6577, 6578, 6579, 6580, 6701, 6702, 6703, 6704, 6705, 6706, 6707, 6708, 6709, 6710, 6711, 6712, 6713, 6714, 6715, 6716, 6717, 6718, 6719, 6720, 6721, 6722, 6723, 6724, 6725, 6726, 6727, 6728, 6729}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "StairsOkPass", value: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {10})) {
                    context.State = new State던전코드별보스등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전코드별보스등장 : TriggerState {
            internal State던전코드별보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetDungeonId() == 23042003) {
                    context.State = new State어려움난이도보스등장(context);
                    return;
                }

                if (context.GetDungeonId() == 23043003) {
                    context.State = new State쉬움난이도보스등장(context);
                    return;
                }

                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State어려움난이도보스등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어려움난이도보스등장 : TriggerState {
            internal State어려움난이도보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {99, 97}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State인페르녹최초이미지대사연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉬움난이도보스등장 : TriggerState {
            internal State쉬움난이도보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {98, 96}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State인페르녹최초이미지대사연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인페르녹최초이미지대사연출 : TriggerState {
            internal State인페르녹최초이미지대사연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23000150, illust: "infernog_nomal", duration: 9000, script: "$02020098_BF__PopUpCinema__0$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State대기상태(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기상태 : TriggerState {
            internal State대기상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "StairsOk") == 1) {
                    context.State = new State계단생성시작중(context);
                    return;
                }

                if (context.GetUserValue(key: "2PhaseStart") == 1) {
                    context.State = new State2페이지_바로가기포탈생성(context);
                    return;
                }

                if (context.GetUserValue(key: "3PhaseStart") == 1) {
                    context.State = new State3페이지_바로가기포탈생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State계단생성시작중 : TriggerState {
            internal State계단생성시작중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "StairsOk", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "StairsOkPass") == 0) {
                    context.State = new State계단생성(context);
                    return;
                }

                if (context.GetUserValue(key: "StairsOkPass") == 1) {
                    context.State = new State대기상태(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State계단생성 : TriggerState {
            internal State계단생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {198, 199}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178}, arg2: true, arg3: 1, arg4: 50, arg5: 0.5f);
                context.SetPortal(arg1: 10, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State대기상태(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2페이지_바로가기포탈생성 : TriggerState {
            internal State2페이지_바로가기포탈생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {125, 116, 168, 126}, arg2: false, arg3: 0, arg4: 50, arg5: 0.5f);
                context.SetUserValue(key: "2PhaseStart", value: 0);
                context.SetPortal(arg1: 20, arg2: true, arg3: true, arg4: true);
                context.SetMesh(arg1: new[] {198, 199}, arg2: true, arg3: 1, arg4: 1, arg5: 1f);
                context.SetMesh(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178}, arg2: false, arg3: 0, arg4: 50, arg5: 0.5f);
                context.SetUserValue(key: "StairsOkPass", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6300)) {
                    context.State = new State2페이지_2PhaseWall_생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2페이지_2PhaseWall_생성 : TriggerState {
            internal State2페이지_2PhaseWall_생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6501, 6502, 6503, 6504, 6505, 6506, 6507, 6508, 6509, 6510, 6511, 6512, 6513, 6514, 6515, 6516, 6517, 6518, 6519, 6520, 6521, 6522, 6523, 6524, 6525, 6526, 6527, 6528, 6529, 6530, 6531, 6532, 6533, 6534, 6535, 6536, 6537, 6538, 6539, 6540, 6541, 6542, 6543, 6544, 6545, 6546, 6547, 6548, 6549, 6550, 6551, 6552, 6553, 6554, 6555, 6556, 6557, 6558, 6559, 6560, 6561, 6562, 6563, 6564, 6565, 6566, 6567, 6568, 6569, 6570, 6571, 6572, 6573, 6574, 6575, 6576, 6577, 6578, 6579, 6580}, arg2: true, arg3: 1, arg4: 1, arg5: 1f);
                context.SetMesh(arg1: new[] {6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011, 6012, 6013, 6014, 6015, 6016, 6017, 6018, 6019, 6020, 6021, 6022, 6023, 6024, 6025, 6026, 6027, 6028, 6029, 6030, 6031, 6032, 6033, 6034, 6035, 6036, 6037, 6038, 6039, 6040, 6041, 6042, 6043, 6044, 6045, 6046, 6047, 6048, 6049, 6050, 6051, 6052, 6053, 6054, 6055, 6056, 6057, 6058, 6059, 6060, 6061, 6062, 6063, 6064, 6065, 6066, 6067, 6068, 6069, 6070, 6071, 6072}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State대기상태(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3페이지_바로가기포탈생성 : TriggerState {
            internal State3페이지_바로가기포탈생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 60, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 61, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 62, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 63, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 64, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 65, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 66, arg2: false, arg3: false, arg4: false);
                context.SetUserValue(key: "3PhaseStart", value: 0);
                context.SetPortal(arg1: 30, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 20, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6300)) {
                    context.State = new State3페이지_3PhaseWall_생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3페이지_3PhaseWall_생성 : TriggerState {
            internal State3페이지_3PhaseWall_생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6701, 6702, 6703, 6704, 6705, 6706, 6707, 6708, 6709, 6710, 6711, 6712, 6713, 6714, 6715, 6716, 6717, 6718, 6719, 6720, 6721, 6722, 6723, 6724, 6725, 6726, 6727, 6728, 6729}, arg2: true, arg3: 1, arg4: 1, arg5: 1f);
                context.SetMesh(arg1: new[] {6501, 6502, 6503, 6504, 6505, 6506, 6507, 6508, 6509, 6510, 6511, 6512, 6513, 6514, 6515, 6516, 6517, 6518, 6519, 6520, 6521, 6522, 6523, 6524, 6525, 6526, 6527, 6528, 6529, 6530, 6531, 6532, 6533, 6534, 6535, 6536, 6537, 6538, 6539, 6540, 6541, 6542, 6543, 6544, 6545, 6546, 6547, 6548, 6549, 6550, 6551, 6552, 6553, 6554, 6555, 6556, 6557, 6558, 6559, 6560, 6561, 6562, 6563, 6564, 6565, 6566, 6567, 6568, 6569, 6570, 6571, 6572, 6573, 6574, 6575, 6576, 6577, 6578, 6579, 6580}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State대기상태(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
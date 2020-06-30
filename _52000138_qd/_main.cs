using System;
using System.Numerics;

namespace Maple2.Trigger._52000138_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7101, arg2: true);
                context.SetActor(arg1: 4001, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4002, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4003, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4004, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4005, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4006, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4007, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4008, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4009, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4010, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4011, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 1001, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1002, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1003, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1004, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1005, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1006, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1007, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1008, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1009, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1010, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1011, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1012, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1013, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1014, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1015, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1016, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1017, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1018, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1019, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1020, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1021, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1022, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1023, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1024, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1025, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1026, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1027, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1028, arg2: true, arg3: "sf_quest_light_A01_Off");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "701")) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG\weather\Eff_monochrome_03.xml");
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/Sound/Eff_ Object_Train_alert.xml");
                context.SetAmbientLight(arg1: new Vector3(0f, 0f, 0f));
                context.SetAmbientLight(arg1: new Vector3(1f, 1f, 1f));
                context.AddBuff(arg1: new int[] {701}, arg2: 99910230, arg3: 1, arg4: false, arg5: true);
                context.AddBuff(arg1: new int[] {701}, arg2: 99910230, arg3: 1, arg4: false, arg5: false);
                context.CreateMonster(arg1: new int[] {101});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateact1_wave1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateact1_wave1 : TriggerState {
            internal Stateact1_wave1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$52000138_QD__MAIN__0$", arg3: new int[] {3000}, arg4: "0");
                context.SetActor(arg1: 1001, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1002, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1003, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1004, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1009, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1010, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1025, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1026, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1027, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1028, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000138_QD__MAIN__1$", arg4: 3, arg5: 0);
                context.SetSound(arg1: 10000, arg2: true);
                context.SetSound(arg1: 7002, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1)) {
                    context.State = new Stateact1_wave2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateact1_wave2 : TriggerState {
            internal Stateact1_wave2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {102});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1)) {
                    context.State = new Stateact1_wave2_move(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateact1_wave2_move : TriggerState {
            internal Stateact1_wave2_move(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4001, arg2: true, arg3: "Opened");
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000138_QD__MAIN__2$", arg4: 3, arg5: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateact1_wave2_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateact1_wave2_1 : TriggerState {
            internal Stateact1_wave2_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {104});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1)) {
                    context.State = new Stateact1_wave2_move_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateact1_wave2_move_1 : TriggerState {
            internal Stateact1_wave2_move_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4002, arg2: true, arg3: "Opened");
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$52000138_QD__MAIN__3$", arg4: 3, arg5: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateact1_wave3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateact1_wave3 : TriggerState {
            internal Stateact1_wave3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {103, 105});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateact1_wave3_move(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateact1_wave3_move : TriggerState {
            internal Stateact1_wave3_move(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 105, arg3: "$52000138_QD__MAIN__4$", arg4: 3, arg5: 3);
                context.SetActor(arg1: 4003, arg2: true, arg3: "Opened");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "702")) {
                    context.State = new Stateready_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready_1 : TriggerState {
            internal Stateready_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {110, 111});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Stateact2_wave1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateact2_wave1 : TriggerState {
            internal Stateact2_wave1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 1005, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1006, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1007, arg2: true, arg3: "sf_quest_light_A01_Of");
                context.SetActor(arg1: 1008, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1011, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1012, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1011, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1012, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1023, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1024, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$52000138_QD__MAIN__5$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 111, arg3: "$52000138_QD__MAIN__6$", arg4: 3, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1)) {
                    context.State = new Stateact2_wave2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateact2_wave2 : TriggerState {
            internal Stateact2_wave2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4004, arg2: true, arg3: "Opened");
                context.CreateMonster(arg1: new int[] {106, 107});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1)) {
                    context.State = new Stateact2_wave2_move(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateact2_wave2_move : TriggerState {
            internal Stateact2_wave2_move(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 106, arg3: "$52000138_QD__MAIN__7$", arg4: 3, arg5: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateact2_wave3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateact2_wave3 : TriggerState {
            internal Stateact2_wave3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4005, arg2: true, arg3: "Opened");
                context.CreateMonster(arg1: new int[] {108, 109});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Stateact2_wave3_move(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateact2_wave3_move : TriggerState {
            internal Stateact2_wave3_move(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4006, arg2: true, arg3: "Opened");
                context.SetConversation(arg1: 1, arg2: 109, arg3: "$52000138_QD__MAIN__8$", arg4: 3, arg5: 3);
                context.CreateMonster(arg1: new int[] {112});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Stateact2_wave3_move_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateact2_wave3_move_1 : TriggerState {
            internal Stateact2_wave3_move_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 112, arg3: "$52000138_QD__MAIN__9$", arg4: 3, arg5: 4);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "703")) {
                    context.State = new Stateready_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready_2 : TriggerState {
            internal Stateready_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {113});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1)) {
                    context.State = new Stateact3_wave1_move(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateact3_wave1_move : TriggerState {
            internal Stateact3_wave1_move(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 1013, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1014, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1015, arg2: true, arg3: "sf_quest_light_A01_Of");
                context.SetActor(arg1: 1016, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1017, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1018, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1019, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1020, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1021, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 1022, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetConversation(arg1: 1, arg2: 113, arg3: "$52000138_QD__MAIN__10$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1)) {
                    context.State = new Stateact3_wave2_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateact3_wave2_1 : TriggerState {
            internal Stateact3_wave2_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {114, 115, 120, 121});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateact3_wave2_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateact3_wave2_2 : TriggerState {
            internal Stateact3_wave2_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 114, arg3: "$52000138_QD__MAIN__11$", arg4: 2, arg5: 2);
                context.CreateMonster(arg1: new int[] {116, 117, 118, 119});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateact3_wave2_move(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateact3_wave2_move : TriggerState {
            internal Stateact3_wave2_move(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 116, arg3: "$52000138_QD__MAIN__12$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {
                    101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120,
                    121, 122, 123
                })) {
                    context.State = new Stateescape(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateescape : TriggerState {
            internal Stateescape(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new int[] {122});
                context.CameraSelectPath(arg1: new int[] {8001}, arg2: 0);
                context.SetSceneSkip(arg1: "endready", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateplot(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateplot : TriggerState {
            internal Stateplot(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7102, arg2: true);
                context.SetConversation(arg1: 1, arg2: 122, arg3: "$52000138_QD__MAIN__13$", arg4: 3, arg5: 4);
                context.MoveNpc(arg1: 122, arg2: "MS2PatrolData_2001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new Statescheme1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescheme1 : TriggerState {
            internal Statescheme1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 122, arg3: "$52000138_QD__MAIN__14$", arg4: 5, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statescheme2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescheme2 : TriggerState {
            internal Statescheme2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 122, arg3: "$52000138_QD__MAIN__15$", arg4: 5, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statescheme3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescheme3 : TriggerState {
            internal Statescheme3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 122, arg3: "$52000138_QD__MAIN__16$", arg4: 5, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statescheme4(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CameraSelectPath(arg1: new int[] {8002}, arg2: 0);
            }
        }

        private class Statescheme4 : TriggerState {
            internal Statescheme4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 122, arg2: "Talk_A", arg3: 1500f);
                context.SetConversation(arg1: 1, arg2: 122, arg3: "$52000138_QD__MAIN__17$", arg4: 5, arg5: 0);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Stateendready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateendready : TriggerState {
            internal Stateendready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "windead");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "windead");
                context.MoveUser(arg1: 02000153, arg2: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
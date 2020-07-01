namespace Maple2.Trigger._52000067_qd {
    public static class _main {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.SetTimeScale(enable: false, startScale: 1f, endScale: 1f, duration: 0f, interpolator: 0);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetInteractObject(arg1: new[] {10001073}, arg2: 2);
                context.SetEffect(arg1: new[] {7005, 7001, 7010, 7011, 7012, 7013, 7014, 7015, 7016, 7110, 7111, 7112, 7113, 7114, 7115, 7116, 7301, 7302, 7303, 7304, 7305, 7306, 7307, 7308, 7309, 7310, 7117}, arg2: false);
                context.SetActor(arg1: 4999, arg2: false, arg3: "Regen_A");
                context.SetActor(arg1: 4001, arg2: false, arg3: "Attack_02_H");
                context.SetActor(arg1: 4002, arg2: false, arg3: "Dead_Idle_A");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.MoveUser(arg1: 52000067, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 702) == 1) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetEffect(arg1: new[] {7005}, arg2: true);
                context.SetProductionUI(arg1: 9, arg2: "$52000067_QD__MAIN__0$", arg3: false);
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new Statestart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7005}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.RemoveBuff(arg1: 702, arg2: 99910070);
                context.CreateMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 551, 552, 553, 554, 555, 520, 521, 522, 523, 524, 525, 526, 527, 528, 529, 530, 531, 532, 533, 534, 535, 536}, arg2: true);
                context.CreateMonster(arg1: new[] {121, 121, 123, 752, 753, 754}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_1002");
                context.CameraSelectPath(arg1: new[] {8001, 8002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new Stateportal_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateportal_01 : TriggerState {
            internal Stateportal_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7301, 7010}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateportal_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateportal_02 : TriggerState {
            internal Stateportal_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7302, 7016}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateportal_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateportal_03 : TriggerState {
            internal Stateportal_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7303, 7013}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateportal_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateportal_04 : TriggerState {
            internal Stateportal_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7304, 7012, 7014}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateportal_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateportal_05 : TriggerState {
            internal Stateportal_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7015}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateportal_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateportal_06 : TriggerState {
            internal Stateportal_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7011}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_01 : TriggerState {
            internal Statescene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new Statescene_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_02 : TriggerState {
            internal Statescene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_03a(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_03a : TriggerState {
            internal Statescene_03a(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__1$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_03b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_03b : TriggerState {
            internal Statescene_03b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1003");
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__2$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene_03c(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_03c : TriggerState {
            internal Statescene_03c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2002");
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__3$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_03c_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_03c_02 : TriggerState {
            internal Statescene_03c_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7305}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new Statescene_03d(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_03d : TriggerState {
            internal Statescene_03d(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000067_QD__MAIN__22$", arg4: 2, arg5: 0);
                context.MoveUserPath(arg1: "MS2PatrolData_1004");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_03 : TriggerState {
            internal Statescene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_05 : TriggerState {
            internal Statescene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4001, arg2: true, arg3: "Regen_A");
                context.SetEffect(arg1: new[] {7001}, arg2: true);
                context.SetTimeScale(enable: true, startScale: 1f, endScale: 0.1f, duration: 2.0f, interpolator: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    context.State = new Statescene_05_a(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_05_a : TriggerState {
            internal Statescene_05_a(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Jump_Damg_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1400)) {
                    context.State = new Statescene_05_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_05_b : TriggerState {
            internal Statescene_05_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_05_d(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_05_d : TriggerState {
            internal Statescene_05_d(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enable: true, startScale: 0.1f, endScale: 1f, duration: 1f, interpolator: 2);
                context.CameraSelectPath(arg1: new[] {8099, 8005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_06 : TriggerState {
            internal Statescene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enable: false, startScale: 1f, endScale: 1f, duration: 1f, interpolator: 0);
                context.CameraSelectPath(arg1: new[] {8005, 8006}, arg2: false);
                context.SetActor(arg1: 4001, arg2: true, arg3: "Idle_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_07 : TriggerState {
            internal Statescene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enable: false, startScale: 0f, endScale: 0f, duration: 0f, interpolator: 0);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2003");
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__4$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_08 : TriggerState {
            internal Statescene_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8006, 8007}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__5$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_09 : TriggerState {
            internal Statescene_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__6$", arg4: 3);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statefadeout(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.RemoveBuff(arg1: 702, arg2: 99910070);
                context.DestroyMonster(arg1: new[] {201});
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 121, 122, 123});
                context.DestroyMonster(arg1: new[] {501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 520, 521, 522, 523, 524, 525, 526, 527, 528, 529, 531, 532, 533, 534, 535, 536, 537, 538, 539, 551, 552, 553, 554, 555, 556, 557, 558, 559, 751, 752, 753, 754, 756, 757, 758, 759, 761, 762});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSkip_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201});
                context.CreateMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 551, 552, 553, 554, 555, 520, 521, 522, 523, 524, 525, 526, 527, 528, 529, 530, 531, 532, 533, 534, 535, 536}, arg2: true);
                context.CreateMonster(arg1: new[] {121, 121, 123, 752, 753, 754}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_1002");
                context.CameraSelectPath(arg1: new[] {8001, 8002}, arg2: false);
                context.SetActor(arg1: 4001, arg2: true, arg3: "Regen_A");
                context.SetEffect(arg1: new[] {7001, 7010, 7011, 7012, 7013, 7014, 7015, 7016}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statefadeout(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefadeout : TriggerState {
            internal Statefadeout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2002");
                context.SetEffect(arg1: new[] {7005}, arg2: true);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statefadein(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefadein : TriggerState {
            internal Statefadein(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2003");
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 25200671, textId: 25200671);
                context.SetMesh(arg1: new[] {6004, 6005}, arg2: true, arg3: 0, arg4: 0, arg5: 10f);
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$52000067_QD__MAIN__7$", arg4: 3, arg5: 2);
                context.SetInteractObject(arg1: new[] {10001073}, arg2: 1);
                context.SetActor(arg1: 4001, arg2: false, arg3: "Regen_A");
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetEffect(arg1: new[] {7005}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001073}, arg2: 0)) {
                    context.State = new Stateplay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateplay : TriggerState {
            internal Stateplay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7310}, arg2: true);
                context.HideGuideSummary(entityId: 25200671);
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$52000067_QD__MAIN__8$", arg4: 3, arg5: 0);
                context.SetMesh(arg1: new[] {6001, 6002, 6003, 6004, 6005}, arg2: false, arg3: 0, arg4: 0, arg5: 10f);
                context.SetInteractObject(arg1: new[] {10001073}, arg2: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateGuideMission(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {801, 802, 803, 804, 805, 806, 807})) {
                    context.State = new Stateboss_event(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideMission : TriggerState {
            internal StateGuideMission(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$52000067_QD__MAIN__9$", arg3: 3000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {801, 802, 803, 804, 805, 806, 807})) {
                    context.State = new Stateboss_event(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateboss_event : TriggerState {
            internal Stateboss_event(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetEffect(arg1: new[] {7005}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateboss_event_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateboss_event_02 : TriggerState {
            internal Stateboss_event_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000067, arg2: 2);
                context.SetEffect(arg1: new[] {7005}, arg2: false);
                context.CameraSelectPath(arg1: new[] {8008, 8009}, arg2: false);
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 121, 122, 123});
                context.DestroyMonster(arg1: new[] {501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 520, 521, 522, 523, 524, 525, 526, 527, 528, 529, 531, 532, 533, 534, 535, 536, 537, 538, 539, 551, 552, 553, 554, 555, 556, 557, 558, 559, 801, 802, 803, 804, 805, 806, 807, 751, 752, 753, 754, 756, 757, 758, 759, 761, 762});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateboss_event_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateboss_event_03 : TriggerState {
            internal Stateboss_event_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7306}, arg2: true);
                context.CreateMonster(arg1: new[] {999}, arg2: true, arg3: 5000);
                context.SetSceneSkip(arg1: "Skip_3", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Stateboss_event_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateboss_event_04 : TriggerState {
            internal Stateboss_event_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8010, 8011}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 999, arg2: "AttackReady_A");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Stateboss_event_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_3 : TriggerState {
            internal StateSkip_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateboss_event_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateboss_event_05 : TriggerState {
            internal Stateboss_event_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8012}, arg2: false);
                context.SetEffect(arg1: new[] {7005}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateboss_event_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateboss_event_06 : TriggerState {
            internal Stateboss_event_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetEffect(arg1: new[] {7005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateboss_event_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateboss_event_07 : TriggerState {
            internal Stateboss_event_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {999})) {
                    context.State = new Stateending_ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_ready : TriggerState {
            internal Stateending_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Stateending(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending : TriggerState {
            internal Stateending(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_4", arg2: "exit");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetEffect(arg1: new[] {7005}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateending_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_02 : TriggerState {
            internal Stateending_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleBreakableObject(arg1: new[] {6300, 6301, 6302, 6303, 6304, 6305, 6306, 6307, 6308, 6309, 6310, 6311, 6312, 6313, 6314, 6315, 6316, 6317, 6318, 6319, 6320, 6321, 6322, 6323, 6324, 6325, 6326, 6327, 6328, 6329, 6330, 6331}, arg2: false);
                context.RemoveBuff(arg1: 702, arg2: 99910070);
                context.SetProductionUI(arg1: 9, arg2: "$52000067_QD__MAIN__10$", arg3: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateending_02_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_02_b : TriggerState {
            internal Stateending_02_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {851, 852, 853, 854, 855, 856, 857, 858, 859, 860, 861, 862, 863, 864, 865, 866, 867, 868, 869, 870}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateending_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_03 : TriggerState {
            internal Stateending_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7307}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 861, arg3: "$52000067_QD__MAIN__11$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 853, arg3: "$52000067_QD__MAIN__12$", arg4: 2, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 851, arg3: "$52000067_QD__MAIN__13$", arg4: 3, arg5: 3);
                context.SetConversation(arg1: 1, arg2: 861, arg3: "$52000067_QD__MAIN__14$", arg4: 3, arg5: 4);
                context.SetConversation(arg1: 1, arg2: 862, arg3: "$52000067_QD__MAIN__15$", arg4: 3, arg5: 2);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {8014, 8015}, arg2: false);
                context.SetEffect(arg1: new[] {7005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new Stateending_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_04 : TriggerState {
            internal Stateending_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7117}, arg2: true);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2003");
                context.MoveUser(arg1: 52000067, arg2: 3);
                context.SetActor(arg1: 4002, arg2: true, arg3: "Dead_Idle_A");
                context.SetEffect(arg1: new[] {7005}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateending_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_05 : TriggerState {
            internal Stateending_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8016, 8017}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateending_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_06 : TriggerState {
            internal Stateending_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7308}, arg2: true);
                context.SetEffect(arg1: new[] {7005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateending_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_07 : TriggerState {
            internal Stateending_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__16$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Stateending_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_08 : TriggerState {
            internal Stateending_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__17$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Stateending_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_09 : TriggerState {
            internal Stateending_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8018}, arg2: false);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2004");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateending_09_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_09_b : TriggerState {
            internal Stateending_09_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1005");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Stateending_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_10 : TriggerState {
            internal Stateending_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__18$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Stateending_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_11 : TriggerState {
            internal Stateending_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2005");
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__19$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Stateending_12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_12 : TriggerState {
            internal Stateending_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__20$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Stateending_12_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_12_b : TriggerState {
            internal Stateending_12_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1006");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateending_13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_13 : TriggerState {
            internal Stateending_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2006");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateending_14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_14 : TriggerState {
            internal Stateending_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8019}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Stateending_15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_15 : TriggerState {
            internal Stateending_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__21$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Stateending_16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_16 : TriggerState {
            internal Stateending_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8020}, arg2: false);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_1006");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new Stateending_17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_17 : TriggerState {
            internal Stateending_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7309}, arg2: true);
                context.SetActor(arg1: 4002, arg2: true, arg3: "Dead_Damg_A");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateending_18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_4 : TriggerState {
            internal StateSkip_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetAchievement(arg1: 702, arg2: "trigger", arg3: "CityWarfareClear");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateend02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateending_18 : TriggerState {
            internal Stateending_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7005}, arg2: true);
                context.SetAchievement(arg1: 702, arg2: "trigger", arg3: "CityWarfareClear");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateend01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend01 : TriggerState {
            internal Stateend01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.PlaySceneMovie(fileName: "Aftermath_Madria.swf");
                context.SetSceneSkip(arg1: "end02", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new Stateend02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend02 : TriggerState {
            internal Stateend02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000055, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
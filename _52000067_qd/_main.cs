namespace Maple2.Trigger._52000067_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

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

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 702) == 1) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetEffect(arg1: new[] {7005}, arg2: true);
                context.SetProductionUI(arg1: 9, arg2: "$52000067_QD__MAIN__0$", arg3: false);
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StatePortal_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal_01 : TriggerState {
            internal StatePortal_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7301, 7010}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePortal_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal_02 : TriggerState {
            internal StatePortal_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7302, 7016}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePortal_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal_03 : TriggerState {
            internal StatePortal_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7303, 7013}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePortal_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal_04 : TriggerState {
            internal StatePortal_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7304, 7012, 7014}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePortal_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal_05 : TriggerState {
            internal StatePortal_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7015}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePortal_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal_06 : TriggerState {
            internal StatePortal_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7011}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_01 : TriggerState {
            internal StateScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2001");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateScene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_02 : TriggerState {
            internal StateScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_03a(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_03a : TriggerState {
            internal StateScene_03a(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__1$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_03b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_03b : TriggerState {
            internal StateScene_03b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1003");
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__2$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_03c(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_03c : TriggerState {
            internal StateScene_03c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2002");
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__3$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_03c_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_03c_02 : TriggerState {
            internal StateScene_03c_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7305}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateScene_03d(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_03d : TriggerState {
            internal StateScene_03d(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000067_QD__MAIN__22$", arg4: 2, arg5: 0);
                context.MoveUserPath(arg1: "MS2PatrolData_1004");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_03 : TriggerState {
            internal StateScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_05 : TriggerState {
            internal StateScene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4001, arg2: true, arg3: "Regen_A");
                context.SetEffect(arg1: new[] {7001}, arg2: true);
                context.SetTimeScale(enable: true, startScale: 1f, endScale: 0.1f, duration: 2.0f, interpolator: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    return new StateScene_05_a(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_05_a : TriggerState {
            internal StateScene_05_a(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Jump_Damg_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1400)) {
                    return new StateScene_05_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_05_b : TriggerState {
            internal StateScene_05_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_05_d(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_05_d : TriggerState {
            internal StateScene_05_d(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enable: true, startScale: 0.1f, endScale: 1f, duration: 1f, interpolator: 2);
                context.CameraSelectPath(arg1: new[] {8099, 8005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_06 : TriggerState {
            internal StateScene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enable: false, startScale: 1f, endScale: 1f, duration: 1f, interpolator: 0);
                context.CameraSelectPath(arg1: new[] {8005, 8006}, arg2: false);
                context.SetActor(arg1: 4001, arg2: true, arg3: "Idle_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_07 : TriggerState {
            internal StateScene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enable: false, startScale: 0f, endScale: 0f, duration: 0f, interpolator: 0);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2003");
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__4$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_08 : TriggerState {
            internal StateScene_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8006, 8007}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__5$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_09 : TriggerState {
            internal StateScene_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__6$", arg4: 3);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateFadeout(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSkip_2(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFadeout(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeout : TriggerState {
            internal StateFadeout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2002");
                context.SetEffect(arg1: new[] {7005}, arg2: true);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateFadein(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadein : TriggerState {
            internal StateFadein(ITriggerContext context) : base(context) { }

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

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001073}, arg2: 0)) {
                    return new StatePlay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlay : TriggerState {
            internal StatePlay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7310}, arg2: true);
                context.HideGuideSummary(entityId: 25200671);
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$52000067_QD__MAIN__8$", arg4: 3, arg5: 0);
                context.SetMesh(arg1: new[] {6001, 6002, 6003, 6004, 6005}, arg2: false, arg3: 0, arg4: 0, arg5: 10f);
                context.SetInteractObject(arg1: new[] {10001073}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateGuideMission(context);
                }

                if (context.MonsterDead(arg1: new[] {801, 802, 803, 804, 805, 806, 807})) {
                    return new StateBoss_event(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuideMission : TriggerState {
            internal StateGuideMission(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$52000067_QD__MAIN__9$", arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {801, 802, 803, 804, 805, 806, 807})) {
                    return new StateBoss_event(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_event : TriggerState {
            internal StateBoss_event(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetEffect(arg1: new[] {7005}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBoss_event_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_event_02 : TriggerState {
            internal StateBoss_event_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000067, arg2: 2);
                context.SetEffect(arg1: new[] {7005}, arg2: false);
                context.CameraSelectPath(arg1: new[] {8008, 8009}, arg2: false);
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 121, 122, 123});
                context.DestroyMonster(arg1: new[] {501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 520, 521, 522, 523, 524, 525, 526, 527, 528, 529, 531, 532, 533, 534, 535, 536, 537, 538, 539, 551, 552, 553, 554, 555, 556, 557, 558, 559, 801, 802, 803, 804, 805, 806, 807, 751, 752, 753, 754, 756, 757, 758, 759, 761, 762});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBoss_event_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_event_03 : TriggerState {
            internal StateBoss_event_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7306}, arg2: true);
                context.CreateMonster(arg1: new[] {999}, arg2: true, arg3: 5000);
                context.SetSceneSkip(arg1: "Skip_3", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBoss_event_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_event_04 : TriggerState {
            internal StateBoss_event_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8010, 8011}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 999, arg2: "AttackReady_A");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBoss_event_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_3 : TriggerState {
            internal StateSkip_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBoss_event_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_event_05 : TriggerState {
            internal StateBoss_event_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8012}, arg2: false);
                context.SetEffect(arg1: new[] {7005}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBoss_event_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_event_06 : TriggerState {
            internal StateBoss_event_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetEffect(arg1: new[] {7005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBoss_event_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_event_07 : TriggerState {
            internal StateBoss_event_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {999})) {
                    return new StateEnding_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_ready : TriggerState {
            internal StateEnding_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEnding(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding : TriggerState {
            internal StateEnding(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_4", arg2: "exit");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetEffect(arg1: new[] {7005}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnding_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_02 : TriggerState {
            internal StateEnding_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleBreakableObject(arg1: new[] {6300, 6301, 6302, 6303, 6304, 6305, 6306, 6307, 6308, 6309, 6310, 6311, 6312, 6313, 6314, 6315, 6316, 6317, 6318, 6319, 6320, 6321, 6322, 6323, 6324, 6325, 6326, 6327, 6328, 6329, 6330, 6331}, arg2: false);
                context.RemoveBuff(arg1: 702, arg2: 99910070);
                context.SetProductionUI(arg1: 9, arg2: "$52000067_QD__MAIN__10$", arg3: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnding_02_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_02_b : TriggerState {
            internal StateEnding_02_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {851, 852, 853, 854, 855, 856, 857, 858, 859, 860, 861, 862, 863, 864, 865, 866, 867, 868, 869, 870}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnding_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_03 : TriggerState {
            internal StateEnding_03(ITriggerContext context) : base(context) { }

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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEnding_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_04 : TriggerState {
            internal StateEnding_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7117}, arg2: true);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2003");
                context.MoveUser(arg1: 52000067, arg2: 3);
                context.SetActor(arg1: 4002, arg2: true, arg3: "Dead_Idle_A");
                context.SetEffect(arg1: new[] {7005}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnding_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_05 : TriggerState {
            internal StateEnding_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8016, 8017}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnding_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_06 : TriggerState {
            internal StateEnding_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7308}, arg2: true);
                context.SetEffect(arg1: new[] {7005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnding_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_07 : TriggerState {
            internal StateEnding_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__16$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEnding_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_08 : TriggerState {
            internal StateEnding_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__17$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEnding_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_09 : TriggerState {
            internal StateEnding_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8018}, arg2: false);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2004");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnding_09_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_09_b : TriggerState {
            internal StateEnding_09_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1005");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnding_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_10 : TriggerState {
            internal StateEnding_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__18$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEnding_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_11 : TriggerState {
            internal StateEnding_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2005");
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__19$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEnding_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_12 : TriggerState {
            internal StateEnding_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__20$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEnding_12_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_12_b : TriggerState {
            internal StateEnding_12_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1006");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnding_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_13 : TriggerState {
            internal StateEnding_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2006");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnding_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_14 : TriggerState {
            internal StateEnding_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8019}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnding_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_15 : TriggerState {
            internal StateEnding_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000067_QD__MAIN__21$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnding_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_16 : TriggerState {
            internal StateEnding_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8020}, arg2: false);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_1006");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEnding_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_17 : TriggerState {
            internal StateEnding_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7309}, arg2: true);
                context.SetActor(arg1: 4002, arg2: true, arg3: "Dead_Damg_A");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnding_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_4 : TriggerState {
            internal StateSkip_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetAchievement(arg1: 702, arg2: "trigger", arg3: "CityWarfareClear");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_18 : TriggerState {
            internal StateEnding_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7005}, arg2: true);
                context.SetAchievement(arg1: 702, arg2: "trigger", arg3: "CityWarfareClear");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd01 : TriggerState {
            internal StateEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.PlaySceneMovie(fileName: "Aftermath_Madria.swf");
                context.SetSceneSkip(arg1: "end02", arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateEnd02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd02 : TriggerState {
            internal StateEnd02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000055, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}